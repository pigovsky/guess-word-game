package com.tneu.fcit.softwareconstructing.guesstheword.model;

import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ListCell;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.Priority;

public final class PlayerCell extends ListCell<User> {

    private HBox hBox = new HBox();
    private Pane pane = new Pane();
    private Label nameLabel = new Label();
    private Button deleteButton = new Button();

    private User lastItem;

    public PlayerCell() {
        super();
        deleteButton.setText("Delete");
        deleteButton.setOnAction(event -> PlayerDAO.deleteUser(getListView().getSelectionModel().getSelectedItem()));
        hBox.getChildren().addAll(nameLabel, pane, deleteButton);
        HBox.setHgrow(pane, Priority.ALWAYS);
    }

    @Override
    protected void updateItem(User item, boolean empty) {
        super.updateItem(item, empty);
        setText(null);
        if (empty) {
            lastItem = null;
            setGraphic(null);
        } else {
            lastItem = item;
            nameLabel.setText(item.getName());
            setGraphic(hBox);
        }
    }
}
