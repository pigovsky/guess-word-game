package com.tneu.cpz.guessthewordgame.services;

import com.tneu.cpz.guessthewordgame.model.EncodedCell;

import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class QuestionService {

    public List<EncodedCell> encodeAnswer(String answer) {
        List<EncodedCell> encodedCells = IntStream.range(0, answer.length())
                .mapToObj(i -> new EncodedCell(answer.substring(i, i + 1)))
                .collect(Collectors.toList());
        return encodedCells;
    }
}
