package com.tneu.cpz.guessthewordgame.model;

import java.util.*;

public class QuestionDAO {

    private static final Map<Integer, Question> questionMap = new HashMap<>();

    static{
        questionMap.put(0, new Question("What we use for washing hands ? ", "Soap"));
        questionMap.put(1, new Question("Where do we store our food ?", "Freezer"));
        questionMap.put(2, new Question("Who gives us milk ?","Cow"));
        questionMap.put(3, new Question("What have we buy, if we want to travel by train ?", "Tickets"));
        questionMap.put(4, new Question("Where do we sleep on ?","Bed"));
    }

    public static Question getRandomQuestion() {
        Random random = new Random();
        return questionMap.get(random.nextInt(4));
    }

    public static List getAllQuestions(){
        return Collections.unmodifiableList(Collections.singletonList(questionMap.values()));
    }

    public static void removeQuestion(int id) {
        questionMap.remove(id);
    }
}