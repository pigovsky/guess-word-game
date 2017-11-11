package com.tneu.fcit.softwareconstructing.guesstheword.services;

import javafx.stage.Stage;

import java.io.IOException;

public interface FXMLService {
    void showPrimaryStage(String path, Stage primaryStage) throws IOException;

    void showDialogStage(String path, Stage primaryStage) throws IOException;
}
