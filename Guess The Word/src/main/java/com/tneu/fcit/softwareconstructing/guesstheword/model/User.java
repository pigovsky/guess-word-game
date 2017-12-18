package com.tneu.fcit.softwareconstructing.guesstheword.model;

import lombok.Data;
import lombok.NonNull;

@Data
public class User {
    @NonNull
    private String name;
}
