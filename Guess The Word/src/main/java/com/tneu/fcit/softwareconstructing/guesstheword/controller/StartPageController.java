package com.tneu.fcit.softwareconstructing.guesstheword.controller;

import com.tneu.fcit.softwareconstructing.guesstheword.Main;
import com.tneu.fcit.softwareconstructing.guesstheword.model.PlayerCell;
import com.tneu.fcit.softwareconstructing.guesstheword.model.PlayerDAO;
import com.tneu.fcit.softwareconstructing.guesstheword.model.User;
import javafx.fxml.FXML;
import javafx.scene.control.ListView;

import java.io.IOException;

public class StartPageController {

    @FXML
    private ListView<User> playerListView;

    @FXML
    private void initialize() {
        playerListView.setCellFactory(param -> new PlayerCell());
        playerListView.setItems(PlayerDAO.getPlayers());
    }

    @FXML
    private void handleAddPlayer() throws IOException {
        Main.showAddPlayerPage();
    }

    @FXML
    private void handleStart() throws IOException {
        Main.showMainPage();
    }
}
