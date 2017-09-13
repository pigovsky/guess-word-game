package main.java.com.tneu.fcit.softwareconstructing.guesstheword.services;

import javafx.collections.ObservableList;
import main.java.com.tneu.fcit.softwareconstructing.guesstheword.model.Question;

public interface QuestionService {
    Question ChooseQuestion(ObservableList<Question> listOfQuestions, String theme);
}
