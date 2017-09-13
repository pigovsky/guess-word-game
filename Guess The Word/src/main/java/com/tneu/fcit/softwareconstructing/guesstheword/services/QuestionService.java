package com.tneu.fcit.softwareconstructing.guesstheword.services;

import javafx.collections.ObservableList;
import com.tneu.fcit.softwareconstructing.guesstheword.model.Question;

public interface QuestionService {
    Question ChooseQuestion(ObservableList<Question> listOfQuestions, String theme);
}
