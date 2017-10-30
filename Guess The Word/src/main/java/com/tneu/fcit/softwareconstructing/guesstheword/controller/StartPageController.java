package com.tneu.fcit.softwareconstructing.guesstheword.controller;

import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TextField;
import javafx.scene.control.ToggleGroup;
import com.tneu.fcit.softwareconstructing.guesstheword.Main;
import com.tneu.fcit.softwareconstructing.guesstheword.model.User;

public class StartPageController {
    @FXML
    private TextField firstPlayerNameField;
    @FXML
    private TextField secondPlayerNameField;
    @FXML
    private TextField thirdPlayerNameField;
    @FXML
    private TextField fourthPlayerNameField;
    @FXML
    private RadioButton onePlayer;
    @FXML
    private RadioButton twoPlayers;
    @FXML
    private RadioButton threePlayers;
    @FXML
    private RadioButton fourPlayers;
    @FXML
    private Label onePlayerLabel;
    @FXML
    private Label twoPlayersLabel;
    @FXML
    private Label threePlayersLabel;
    @FXML
    private Label fourPlayersLabel;


    private int amountOfPlayers;

    private Main main;

    public StartPageController() {
    }

    @FXML
    private void initialize() {
        ToggleGroup group = new ToggleGroup();
        onePlayer.setToggleGroup(group);
        twoPlayers.setToggleGroup(group);
        threePlayers.setToggleGroup(group);
        fourPlayers.setToggleGroup(group);

        firstPlayerNameField.setVisible(false);
        secondPlayerNameField.setVisible(false);
        thirdPlayerNameField.setVisible(false);
        fourthPlayerNameField.setVisible(false);

        onePlayerLabel.setVisible(false);
        twoPlayersLabel.setVisible(false);
        threePlayersLabel.setVisible(false);
        fourPlayersLabel.setVisible(false);
    }

    @FXML
    private void handleStart() {
        if (isFieldsValid())
            main.showMainPage(amountOfPlayers, new User(firstPlayerNameField.getText()), new User(secondPlayerNameField.getText()),
                    new User(thirdPlayerNameField.getText()), new User(fourthPlayerNameField.getText()));
    }

    /*
    Returns int value of players.
    Shows TextField for each User.
     */
    @FXML
    private void getAmountOfPlayers() {
        if (twoPlayers.isSelected()) {
            firstPlayerNameField.setVisible(true);
            secondPlayerNameField.setVisible(true);
            thirdPlayerNameField.setVisible(false);
            fourthPlayerNameField.setVisible(false);

            onePlayerLabel.setVisible(true);
            twoPlayersLabel.setVisible(true);
            threePlayersLabel.setVisible(false);
            fourPlayersLabel.setVisible(false);
            amountOfPlayers = 2;
        } else if (threePlayers.isSelected()) {
            firstPlayerNameField.setVisible(true);
            secondPlayerNameField.setVisible(true);
            thirdPlayerNameField.setVisible(true);
            fourthPlayerNameField.setVisible(false);

            onePlayerLabel.setVisible(true);
            twoPlayersLabel.setVisible(true);
            threePlayersLabel.setVisible(true);
            fourPlayersLabel.setVisible(false);
            amountOfPlayers = 3;
        } else if (fourPlayers.isSelected()) {
            firstPlayerNameField.setVisible(true);
            secondPlayerNameField.setVisible(true);
            thirdPlayerNameField.setVisible(true);
            fourthPlayerNameField.setVisible(true);

            onePlayerLabel.setVisible(true);
            twoPlayersLabel.setVisible(true);
            threePlayersLabel.setVisible(true);
            fourPlayersLabel.setVisible(true);
            amountOfPlayers = 4;
        } else {
            firstPlayerNameField.setVisible(true);
            secondPlayerNameField.setVisible(false);
            thirdPlayerNameField.setVisible(false);
            fourthPlayerNameField.setVisible(false);

            onePlayerLabel.setVisible(true);
            twoPlayersLabel.setVisible(false);
            threePlayersLabel.setVisible(false);
            fourPlayersLabel.setVisible(false);
            amountOfPlayers = 1;
        }
    }

    private boolean isFieldsValid() {
        if (amountOfPlayers == 1 && firstPlayerNameField.getText() != null) {
            return true;
        } else if (amountOfPlayers == 2 && firstPlayerNameField.getText() != null && secondPlayerNameField.getText() != null) {
            return true;
        } else if (amountOfPlayers == 3 && firstPlayerNameField.getText() != null && secondPlayerNameField.getText() != null && thirdPlayerNameField.getText() != null) {
            return true;
        } else if (amountOfPlayers == 4 && firstPlayerNameField.getText() != null && secondPlayerNameField.getText() != null && thirdPlayerNameField.getText() != null && fourthPlayerNameField.getText() != null) {
            return true;
        } else return false;
    }

    public void setMain(Main main) {
        this.main = main;
    }
}
