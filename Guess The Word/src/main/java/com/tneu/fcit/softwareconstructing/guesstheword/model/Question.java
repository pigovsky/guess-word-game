package main.java.com.tneu.fcit.softwareconstructing.guesstheword.model;

import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

public class Question {

    private final StringProperty question;
    private final StringProperty answer;
    private final StringProperty theme;

    public Question(){
        this(null,null,null);
    }

    public Question(String question, String answer, String theme){
        this.question = new SimpleStringProperty(question);
        this.answer = new SimpleStringProperty(answer);
        this.theme = new SimpleStringProperty(theme);
    }

    public String getQuestion() {
        return question.get();
    }

    public void setQuestion(String question){
        this.question.set(question);
    }

    public StringProperty questionProperty() {
        return question;
    }

    public String getAnswer() {
        return answer.get();
    }

    public void setAnswer(String answer){
        this.answer.set(answer);
    }

    public StringProperty answerProperty() {
        return answer;
    }

    public String getTheme() {
        return theme.get();
    }

    public void setTheme(String theme){
        this.theme.set(theme);
    }

    public StringProperty themeProperty() {
        return theme;
    }

    @Override
    public String toString() {
        return theme + "." + question + "." + answer;
    }
}
