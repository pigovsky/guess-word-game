package com.tneu.fcit.softwareconstructing.guesstheword;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.BorderPane;
import javafx.stage.Stage;
import com.tneu.fcit.softwareconstructing.guesstheword.controller.MainPageController;
import com.tneu.fcit.softwareconstructing.guesstheword.controller.StartPageController;
import com.tneu.fcit.softwareconstructing.guesstheword.model.User;

import java.io.IOException;

public class Main extends Application {

    private Stage primaryStage;

    public Main() {
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        this.primaryStage = primaryStage;
        primaryStage.setTitle("Guess The Word");

        showStartPage();
    }

    public void showStartPage() {
        try {
            FXMLLoader loader = new FXMLLoader();
            loader.setLocation(Main.class.getResource("/view/StartPage.fxml"));
            AnchorPane page = (AnchorPane) loader.load();

            StartPageController controller = loader.getController();
            controller.setMain(this);

            Scene scene = new Scene(page);
            primaryStage.setScene(scene);
            primaryStage.show();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void showMainPage(int amountOfPlayers, User firstUser, User secondUser, User thirdUser, User fourthUser) {
        try {
            FXMLLoader loader = new FXMLLoader();
            loader.setLocation(Main.class.getResource("/view/MainPage.fxml"));
            BorderPane page = (BorderPane) loader.load();

            MainPageController controller = loader.getController();
            controller.setMain(this);
            controller.setAmountOfPlayers(amountOfPlayers);
            controller.setAllUsers(firstUser, secondUser, thirdUser, fourthUser);

            Scene scene = new Scene(page);
            primaryStage.setScene(scene);
            primaryStage.show();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        launch(args);
    }
}
