package com.tneu.fcit.softwareconstructing.guesstheword.controller;

import com.tneu.fcit.softwareconstructing.guesstheword.model.PlayerDAO;
import com.tneu.fcit.softwareconstructing.guesstheword.model.User;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.TextField;

public class AddPlayerPageController {
    @FXML
    private TextField playerNameField;

    @FXML
    private void handleAdd() {
        if (isInputValid() && isValidUserAmount()) {
            PlayerDAO.addUser(new User(playerNameField.getText()));
            Alert alert = new Alert(Alert.AlertType.CONFIRMATION);
            alert.showAndWait();
            playerNameField.setText("");
        } else {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.showAndWait();
        }
    }

    private boolean isInputValid() {
        return !playerNameField.getText().equals("") || playerNameField.getText().trim().length() != 0;
    }

    private boolean isValidUserAmount() {
        return PlayerDAO.getPlayers().size() < 4;
    }
}
