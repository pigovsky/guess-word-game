public class WordGuess {

	public static void main(String[] args) {
		Game myGame = new Game("dog");
		Prompter prompter = new Prompter(myGame);
		prompter.play();
	}

}
