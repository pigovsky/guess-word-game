package main.java.com.tneu.fcit.softwareconstructing.guesstheword.controller;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.Label;
import main.java.com.tneu.fcit.softwareconstructing.guesstheword.Main;
import main.java.com.tneu.fcit.softwareconstructing.guesstheword.model.User;

public class MainPageController {
    @FXML
    private Label nameLabel;
    @FXML
    private Label questionLabel;
    @FXML
    private ChoiceBox<String> themeChoiceBox;

    private String username;
    private Main main;
    private int amountOfPlayers;

    private ObservableList<User> users = FXCollections.observableArrayList();

    public MainPageController(){}

    public void setMain(Main main){
        this.main = main;
    }

    public void setUsername(String username){
        this.username = username;
    }

    public void setAmountOfPlayers(int amountOfPlayers){
        this.amountOfPlayers=amountOfPlayers;
    }
    public void setAllUsers(User firstUser, User secondUser,User thirdUser,User fourthUser){
        users.addAll(firstUser,secondUser,thirdUser,fourthUser);
    }
}
