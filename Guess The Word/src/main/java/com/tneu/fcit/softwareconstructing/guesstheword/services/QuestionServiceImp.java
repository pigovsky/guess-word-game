package com.tneu.fcit.softwareconstructing.guesstheword.services;

import com.tneu.fcit.softwareconstructing.guesstheword.model.Question;
import com.tneu.fcit.softwareconstructing.guesstheword.model.QuestionDAO;

import java.util.Random;

public class QuestionServiceImp implements QuestionService {
    @Override
    public Question getRandomQuestion() {
        Random random = new Random();
        return QuestionDAO.getQuestion(random.nextInt(10));
    }
}
