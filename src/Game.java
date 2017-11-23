
public class Game {

	public static final int MAX_MISSES = 7;
	private String answer;
	private String hits;
	private String misses;
	
	
	public Game(String answer){
		this.answer = answer;
		this.hits = "";
		this.misses = "";
	}
	
	private char validateGuess(char letter){
		if (! Character.isLetter(letter)) {
			throw new IllegalArgumentException("A letter is required");
		}
		letter = Character.toLowerCase(letter);
		if (misses.indexOf(letter) >= 0 || hits.indexOf(letter) >= 0) {
			throw new IllegalArgumentException(letter + " has already been guessed");
		}
		return letter;
	}
	
	public boolean applyGuess(String letters){
		if  (letters.length() == 0) {
			throw new IllegalArgumentException("No letter found");
		}
		return applyGuess(letters.charAt(0));
	}
	
	public boolean applyGuess(char letter){
		letter = validateGuess(letter);
		boolean isHit = answer.indexOf(letter) >= 0;
		if(isHit){
			hits += letter;
		}else {
			misses += letter;
		}
		return isHit;
	}

	public String getCurrentProgress(){
		String progress = "";
		for(char letter: answer.toCharArray()){
			char display = '-';
			if(hits.indexOf(letter) >= 0){
				display = letter;
			}
			progress += display;
		}
		return progress;
	}
	
	public int getRemainingTries(){
		return MAX_MISSES - misses.length();
	}
	
	public String getAnswer(){
		return answer;
	}
	
	public boolean isSolved() {
		return getCurrentProgress().indexOf('-') == -1;
	}
	
}//end Game
