package com.tneu.fcit.softwareconstructing.guesstheword.services;

import javafx.stage.Stage;

import java.io.IOException;

public interface FXMLService {
    public void setFXML(String path, Stage primaryStage) throws IOException;
}
