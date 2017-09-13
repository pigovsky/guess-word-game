package com.tneu.fcit.softwareconstructing.guesstheword.services;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import com.tneu.fcit.softwareconstructing.guesstheword.model.Question;

import java.util.Random;

public class QuestionServiceImp implements QuestionService {
    @Override
    public Question ChooseQuestion(ObservableList<Question> listOfQuestions, String theme) {
        Question chosenQuestion;
        ObservableList<Question> sortedByThemeQuestions = FXCollections.observableArrayList();
        for (Question question: listOfQuestions
                ) {
            if(question.getTheme().equals(theme)){
                sortedByThemeQuestions.add(question);
            }
        }
        Random random = new Random();
        //Getting random question from sorted by theme list.
        chosenQuestion = sortedByThemeQuestions.get(random.nextInt(sortedByThemeQuestions.size()));
        return chosenQuestion;
    }
}
