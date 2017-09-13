package com.tneu.fcit.softwareconstructing.guesstheword;

import javafx.application.Application;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.BorderPane;
import javafx.stage.Stage;
import com.tneu.fcit.softwareconstructing.guesstheword.controller.MainPageController;
import com.tneu.fcit.softwareconstructing.guesstheword.controller.StartPageController;
import com.tneu.fcit.softwareconstructing.guesstheword.model.Question;
import com.tneu.fcit.softwareconstructing.guesstheword.model.User;

import java.io.IOException;

public class Main extends Application {

    private Stage primaryStage;
    private ObservableList<Question> listOfQuestions = FXCollections.observableArrayList();

    public Main(){
        listOfQuestions.add(new Question("A ball game in which you can only use legs.","Football","Sport"));
        listOfQuestions.add(new Question("Sports gear that tennis players use to kick off the ball.","Racket","Sport"));
        listOfQuestions.add(new Question("A technical device used to display graphic information on the display.","Videocard","IT"));
        listOfQuestions.add(new Question("The smallest unit of measurement of electronic information.","Byte","IT"));
        listOfQuestions.add(new Question("The largest mammal.","Whale","Nature"));
        listOfQuestions.add(new Question("The most common pet.","Cat","Nature"));
        listOfQuestions.add(new Question("An electrically exciting cell that processes and transmits information in the form of an electrical or chemical signal.","Neuron","Science"));
        listOfQuestions.add(new Question("In which units is power measured?","Watt","Science"));
        listOfQuestions.add(new Question("Which band did a song called 'We are the champions'?","Queen","Music"));
        listOfQuestions.add(new Question("A musical group of four people.","Quartet","Music"));
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        this.primaryStage = primaryStage;
        primaryStage.setTitle("Guess The Word");

        showStartPage();
    }

    public void showStartPage(){
        try{
            FXMLLoader loader = new FXMLLoader();
            loader.setLocation(Main.class.getResource("main/resources/view/StartPage.fxml"));
            AnchorPane page = (AnchorPane)loader.load();

            StartPageController controller = loader.getController();
            controller.setMain(this);

            Scene scene = new Scene(page);
            primaryStage.setScene(scene);
            primaryStage.show();

        }catch (IOException e){
            e.printStackTrace();
        }
    }

    public void showMainPage(int amountOfPlayers, User firstUser, User secondUser, User thirdUser, User fourthUser){
        try{
            FXMLLoader loader = new FXMLLoader();
            loader.setLocation(Main.class.getResource("MainPage.fxml"));
            BorderPane page = (BorderPane)loader.load();

            MainPageController controller = loader.getController();
            controller.setMain(this);
            controller.setAmountOfPlayers(amountOfPlayers);
            controller.setAllUsers(firstUser,secondUser,thirdUser,fourthUser);

            Scene scene = new Scene(page);
            primaryStage.setScene(scene);
            primaryStage.show();

        }catch (IOException e){
            e.printStackTrace();
        }
    }

    public ObservableList<Question> getListOfQuestions() {
        return listOfQuestions;
    }

    public static void main(String[] args){
        launch(args);
    }
}
