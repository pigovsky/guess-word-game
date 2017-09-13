package com.tneu.fcit.softwareconstructing.guesstheword.model;

import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

public class User {
    private final StringProperty username;

    public User(){
        this(null);
    }

    public User(String username){
        this.username = new SimpleStringProperty(username);
    }
}
