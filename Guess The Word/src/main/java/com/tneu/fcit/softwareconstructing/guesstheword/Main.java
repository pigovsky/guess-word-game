package com.tneu.fcit.softwareconstructing.guesstheword;

import com.tneu.fcit.softwareconstructing.guesstheword.services.FXMLService;
import com.tneu.fcit.softwareconstructing.guesstheword.services.FXMLServiceImpl;
import javafx.application.Application;
import javafx.stage.Stage;

import java.io.IOException;

public class Main extends Application {

    private static Stage primaryStage;
    private static final FXMLService fxmlService = new FXMLServiceImpl();

    @Override
    public void start(Stage stage) throws IOException {
        primaryStage = stage;
        primaryStage.setTitle("Guess The Word");

        showStartPage();
    }

    public void showStartPage() throws IOException {
        fxmlService.showPrimaryStage("/view/StartPage.fxml", primaryStage);
    }

    public static void showMainPage() throws IOException {
        fxmlService.showPrimaryStage("/view/MainPage.fxml", primaryStage);
    }

    public static void showAddPlayerPage() throws IOException {
        fxmlService.showDialogStage("/view/AddPlayerPage.fxml", primaryStage);
    }

    public static void main(String[] args) {
        launch(args);
    }
}
