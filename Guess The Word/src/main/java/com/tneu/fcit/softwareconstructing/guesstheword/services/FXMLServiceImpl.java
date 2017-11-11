package com.tneu.fcit.softwareconstructing.guesstheword.services;

import com.tneu.fcit.softwareconstructing.guesstheword.Main;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;

public class FXMLServiceImpl implements FXMLService {

    private Scene getScene(String path, Stage primaryStage) throws IOException {
        FXMLLoader loader = new FXMLLoader();
        loader.setLocation(Main.class.getResource(path));

        AnchorPane pane = (AnchorPane) loader.load();
        return new Scene(pane);
    }

    @Override
    public void showPrimaryStage(String path, Stage primaryStage) throws IOException {
        primaryStage.setScene(getScene(path, primaryStage));
        primaryStage.show();
    }

    @Override
    public void showDialogStage(String path, Stage primaryStage) throws IOException {
        Stage dialogStage = new Stage();
        dialogStage.setTitle("Add Player");
        dialogStage.initModality(Modality.WINDOW_MODAL);
        dialogStage.initOwner(primaryStage);
        dialogStage.setScene(getScene(path, primaryStage));
        dialogStage.showAndWait();
    }
}
