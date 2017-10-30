package com.tneu.fcit.softwareconstructing.guesstheword.model;

import java.util.*;

public class QuestionDAO {
    private static final Map<Integer, Question> questionMap = new HashMap<Integer, Question>();

    static {
        initQuestions();
    }

    private static void initQuestions() {
        questionMap.put(1, new Question("A ball game in which you can only use legs.", "Football"));
        questionMap.put(2, new Question("Sports gear that tennis players use to kick off the ball.", "Racket"));
        questionMap.put(3, new Question("A technical device used to display graphic information on the display.", "Videocard"));
        questionMap.put(4, new Question("The smallest unit of measurement of electronic information.", "Byte"));
        questionMap.put(5, new Question("The largest mammal.", "Whale"));
        questionMap.put(6, new Question("The most common pet.", "Cat"));
        questionMap.put(7, new Question("An electrically exciting cell that processes and transmits information in the form of an electrical or chemical signal.", "Neuron"));
        questionMap.put(8, new Question("In which units is power measured?", "Watt"));
        questionMap.put(9, new Question("Which band did a song called 'We are the champions'?", "Queen"));
        questionMap.put(10, new Question("A musical group of four people.", "Quartet"));
    }

    public static Question getQuestion(int id) {
        return questionMap.get(id);
    }

    public static void deleteQuestion(int id) {
        questionMap.remove(id);
    }

    public static List getAllQuestions() {
        return Collections.unmodifiableList(Collections.singletonList(questionMap.values()));
    }
}
