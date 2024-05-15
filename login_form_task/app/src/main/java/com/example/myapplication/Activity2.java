package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Activity2 extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_2);

        String login = getIntent().getStringExtra("EXTRA_USER_LOGIN");
        String jsonUserList = getIntent().getStringExtra("EXTRA_USER_LIST");
        TextView welcomeUserDiv = findViewById(R.id.tvWelcomeUser);
        welcomeUserDiv.setText("Witaj " + login.toString());


        Button logoutButton = findViewById(R.id.btLogout);

        logoutButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(Activity2.this, MainActivity.class);
                intent.putExtra("EXTRA_USER_LIST", jsonUserList);
                startActivity(intent);
            }
        });

    }

}
