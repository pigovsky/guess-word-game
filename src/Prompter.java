import javax.swing.*;;

public class Prompter {

	private Game currentGame;
	
	public Prompter(Game game){
		this.currentGame = game;
	}
	
	public void play(){
		while (currentGame.getRemainingTries() > 0 && !currentGame.isSolved()){
			displayProgress();
			promptForGuess();
		}
		if (currentGame.isSolved()){
			JOptionPane.showMessageDialog(null, "Congratulations you won with " + currentGame.getRemainingTries() + " remaining tries." );
		} else {
			JOptionPane.showMessageDialog(null, "Bummer the word was " + currentGame.getAnswer());
		}
	}
	
	public boolean promptForGuess(){
		boolean isHit = false;
		boolean isValidGuess = false;
		while(! isValidGuess) {
			String guessAsString = JOptionPane.showInputDialog("Enter a letter: ");
			try {
				isHit = currentGame.applyGuess(guessAsString);
				isValidGuess = true;
			} catch (IllegalArgumentException iae) {
				JOptionPane.showMessageDialog(null, iae.getMessage() + " Please try again.");
			}
			
		}
		return isHit;
	}
	
	public void displayProgress(){
		String message = "You have " + currentGame.getRemainingTries() + " remaining tries. " 
				+ "Try to solve: " + currentGame.getCurrentProgress();
		JOptionPane.showMessageDialog(null, message);
	}
	
}
