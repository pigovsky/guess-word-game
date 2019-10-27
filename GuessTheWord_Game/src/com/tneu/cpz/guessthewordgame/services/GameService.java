package com.tneu.cpz.guessthewordgame.services;

import com.tneu.cpz.guessthewordgame.model.EncodedCell;
import com.tneu.cpz.guessthewordgame.model.Question;
import com.tneu.cpz.guessthewordgame.model.QuestionDAO;
import com.tneu.cpz.guessthewordgame.utils.Constants;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.List;

public class GameService {

    private static QuestionService questionService = new QuestionService();

    public static void startGame() throws IOException {
        Question generatedQuestion = QuestionDAO.getRandomQuestion();
        System.out.println(generatedQuestion.getQuestion());

        List<EncodedCell> encodedCells = questionService.encodeAnswer(generatedQuestion.getAnswer());
        write(encodedCells);
        String input = read();
        while (!input.equals(Constants.EXIT)) {
            checkAnswer(input, encodedCells);
            checkIfWin(generatedQuestion.getAnswer(), encodedCells);
            input = read();
        }
    }

    private static void write(List<EncodedCell> encodedCells) {
        encodedCells.stream()
                .map(EncodedCell::getCell)
                .forEach(System.out::print);
    }

    private static void checkAnswer(String input, List<EncodedCell> encodedCells) {
        encodedCells.stream()
                .filter(encodedCell -> isInputValid(encodedCell.getSecretString()))
                .filter(encodedCell -> input.equals(encodedCell.getSecretString()))
                .forEach(encodedCell -> {
                    encodedCell.setIsSolved();
                    write(encodedCells);
                });
    }

    private static String read() throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        return bufferedReader.readLine();
    }

    private static boolean checkIfWin(String answer, List<EncodedCell> encodedCells){
        boolean isWon = false;
        for (EncodedCell encodedCell:encodedCells
             ) {
            int amount = 0;
            if (encodedCell.isSolved()) {
                amount++;
                if (amount == answer.length()) {
                    isWon = true;
                    System.out.println("You Won!");
                }
            } else
                amount = 0;
        }
        return isWon;
    }

    private static boolean isInputValid(String input) {
        return input.length() < 2 || input.equals(Constants.EXIT);
    }
}
