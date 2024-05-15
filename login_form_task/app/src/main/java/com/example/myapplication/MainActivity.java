package com.example.myapplication;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        /*
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        */


        List<User> userList = new ArrayList<>();

        Intent intent = getIntent();
        if (intent != null && intent.hasExtra("EXTRA_USER_LIST")) {
            String jsonString = intent.getStringExtra("EXTRA_USER_LIST");

            try {
                JSONArray jsonArray = new JSONArray(jsonString);

                for (int i = 0; i < jsonArray.length(); i++) {
                    JSONObject jsonObject = jsonArray.getJSONObject(i);

                    String login = jsonObject.getString("login");
                    String password = jsonObject.getString("password");

                    userList.add(new User(login, password));
                }

                for (User user : userList) {
                    Log.d("User", "Login: " + user.login + ", Password: " + user.password);
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }
        }

        Button loginButton = findViewById(R.id.btLogin);
        Button registerButton = findViewById(R.id.btRegister);
        EditText loginInput = findViewById(R.id.etLogin);
        EditText passwordInput = findViewById(R.id.etPassword);



        loginButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String login = loginInput.getText().toString();
                String password = passwordInput.getText().toString();
                boolean exists = false;
                for (User obj : userList) {
                    // Access the elements of the list
                    if(obj.login.equals(login) && obj.password.equals(password)) {
                        exists = true;
                    }
                }
                if(exists) {
                    Intent intent = new Intent(MainActivity.this, Activity2.class);
                    intent.putExtra("EXTRA_USER_LOGIN", login);

                    StringBuilder jsonBuilder = new StringBuilder();
                    jsonBuilder.append("["); // Start of JSON array

                    for (int i = 0; i < userList.size(); i++) {
                        User user = userList.get(i);
                        jsonBuilder.append("{");
                        jsonBuilder.append("\"login\":\"").append(user.login).append("\",");
                        jsonBuilder.append("\"password\":\"").append(user.password).append("\"");
                        jsonBuilder.append("}");

                        if (i < userList.size() - 1) {
                            jsonBuilder.append(",");
                        }
                    }

                    jsonBuilder.append("]");

                    String jsonUserList = jsonBuilder.toString();
                    intent.putExtra("EXTRA_USER_LIST", jsonUserList);
                    Log.d("JSON", jsonUserList);

                    startActivity(intent);
                }
                else {
                    Toast.makeText(MainActivity.this, "Zarejestruj", Toast.LENGTH_SHORT).show();
                }
            }
        });



        Pattern pattern = Pattern.compile("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]+$");

        registerButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String login = loginInput.getText().toString();
                String password = passwordInput.getText().toString();
                boolean exists = false;

                if(login.isEmpty() || password.isEmpty()) {
                    Toast.makeText(MainActivity.this, "Fill all the fields", Toast.LENGTH_SHORT).show();
                    return;
                }

                Matcher matcher = pattern.matcher(login);
                if(!matcher.find()) {
                    Toast.makeText(MainActivity.this, "Login must be email", Toast.LENGTH_SHORT).show();
                    return;
                }

                for (User obj : userList) {
                    // Access the elements of the list
                    if(obj.login.equals(login)) {
                        exists = true;
                    }
                }

                if(exists) {
                    Toast.makeText(MainActivity.this, "User with this login already exist", Toast.LENGTH_SHORT).show();
                }
                else {
                    userList.add(new User(login, password));

                    Toast.makeText(MainActivity.this, "Registration successful, please log in.", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}