package com.example.ihateandroidstudio;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    int selectedId;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //get all elements by id
        ListView listView = findViewById(R.id.listView);
        Button addItemButton = findViewById(R.id.addItemButton);
        Button replaceItemButton = findViewById(R.id.replaceItemButton);
        TextView input = findViewById(R.id.addItemInput);

        //create array for data for listview
        List<String> data = new ArrayList<>();
        //add example data to data
        data.add("Ogórek");
        data.add("Pomidor");
        data.add("Cukinia");
        data.add("Brzeszczot");

        //create adapter
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, data);
        listView.setAdapter(adapter);

        //add event listener for addItembutton
        addItemButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //add item to data array
                if(!input.getText().toString().isEmpty()) { //input is NOT empty
                    data.add(input.getText().toString());
                    adapter.notifyDataSetChanged();
                    //Toast.makeText(MainActivity.this, input.getText(), Toast.LENGTH_SHORT).show();
                    selectedId = 0;
                    replaceItemButton.setBackgroundColor(Color.parseColor("#919191")); //change replaceItemButton' color to gray
                }
                else { //input is empty
                    //Toast.makeText(MainActivity.this, "wprowadz dane", Toast.LENGTH_SHORT).show();
                }
            }
        });

        //add event listener for items in listView
        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                selectedId = position + 1; //set active element
                input.setText(data.get(selectedId - 1)); //set input text with selected item text
                //Toast.makeText(MainActivity.this, Integer.toString(selectedId), Toast.LENGTH_SHORT).show();
                replaceItemButton.setBackgroundColor(Color.parseColor("#7d44b3")); //change replaceItemButton' color to purple

            }
        });

        //add event listener for replaceItembutton
        replaceItemButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //add item to data array
                if(!input.getText().toString().isEmpty()) { //input is NOT empty
                    if(selectedId != 0) {
                        data.set(selectedId - 1, (input.getText().toString()));
                        adapter.notifyDataSetChanged();
                        //Toast.makeText(MainActivity.this, input.getText(), Toast.LENGTH_SHORT).show();
                    }
                }
                else { //input is empty
                    if(selectedId != 0) {
                        data.remove(selectedId - 1);
                        adapter.notifyDataSetChanged();
                    }
                }
                selectedId = 0;
                replaceItemButton.setBackgroundColor(Color.parseColor("#919191")); //change replaceItemButton' color to gray
            }
        });

        input.addTextChangedListener(new TextWatcher() {

            public void afterTextChanged(Editable s) {
                //set addItemButton' color depending on input text
                if(!input.getText().toString().isEmpty()) {//input is NOT empty
                    addItemButton.setBackgroundColor(Color.parseColor("#7d44b3")); //change replaceItemButton' color to purple
                    Log.i("i","input is NOT empty");
                }
                else {
                    addItemButton.setBackgroundColor(Color.parseColor("#919191")); //change replaceItemButton' color to gray
                    Log.i("i","input is empty");
                }
            }

            public void beforeTextChanged(CharSequence s, int start, int count, int after) {}

            public void onTextChanged(CharSequence s, int start, int before, int count) {}
        });


    }


}