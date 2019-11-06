import java.util.Scanner;
import java.lang.Math;

public class Game {
    public static void main(String[] args) {
       
        int a, b;
        Scanner input = new Scanner(System.in);

        System.out.println("What number did I choose?");

        a = 1 + (int)Math.floor(Math.random() * 10);
       

	do {
	System.out.print("Input your number: ");

	b = input.nextInt();
	
			
	if (b > a)
	System.out.println("My number is smaller");
    
	else if (b < a)            	
	System.out.println("My number is bigger");	 		 		

	else 
	System.out.println("Congratulation! You did it!");
	}
	while (a != b); 
	

    }
}