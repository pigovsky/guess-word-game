package com.tneu.cpz.guessthewordgame.model;

public class EncodedCell {
    private String secretString;
    private final String encodedString = "*";

    private boolean solved = false;

    public EncodedCell(String secretString) {
        this.secretString = secretString;
    }

    public String getSecretString() {
        return secretString;
    }

    public String getCell() {
        return solved ? secretString : encodedString;
    }

    public void setIsSolved() {
        solved = true;
    }

    public boolean isSolved() {
        return solved;
    }
}