package com.tneu.fcit.softwareconstructing.guesstheword.model;
import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.NonNull;
import lombok.RequiredArgsConstructor;

@Data
@NoArgsConstructor
@RequiredArgsConstructor
public class Question {
    @NonNull
    private String question;
    @NonNull
    private String answer;
}
