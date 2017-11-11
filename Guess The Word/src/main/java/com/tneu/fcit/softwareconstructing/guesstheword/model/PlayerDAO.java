package com.tneu.fcit.softwareconstructing.guesstheword.model;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;

public class PlayerDAO {

    private static ObservableList<User> players = FXCollections.observableArrayList();

    public static User getUser(int id) {
        return players.get(id);
    }

    public static void addUser(User user) {
        players.add(user);
    }

    public static void deleteUser(User user) {
        players.remove(user);
    }

    public static ObservableList<User> getPlayers() {
        return players;
    }
}
