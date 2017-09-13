package main.java.com.tneu.fcit.softwareconstructing.guesstheword.model;

import javafx.beans.property.IntegerProperty;
import javafx.beans.property.SimpleIntegerProperty;

public class Point {
    private final IntegerProperty count;

    public Point(){
        this(0);
    }

    public Point(int count){
        this.count  = new SimpleIntegerProperty(count);
    }

    public int getCount() {
        return count.get();
    }

    public void setCount(int count){
        this.count.set(count);
    }

    public IntegerProperty countProperty() {
        return count;
    }
}
