/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tandembicycle;

import java.util.*;
import java.util.Scanner;
/**
 *
 * @author gurla_000
 */
public class TandemBicycle {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input = new Scanner(System.in);
        int question, totalPeople;
        String speedofDmoji, speedOfPegland;
        System.out.println("Question number: ");
        question = input.nextInt();
        System.out.println("Number of People: ");
        totalPeople = input.nextInt();
        input.nextLine();
        System.out.println("Dmojistan Speeds: ");
        speedofDmoji = input.nextLine();
        System.out.println("Pegland Speeds: ");
        speedOfPegland = input.nextLine();
        
        System.out.println(totalSpeeds(question, totalPeople, speedofDmoji,speedOfPegland));
    }
    
    public static int totalSpeeds(int qNum, int numPpl, String speedDmoji, String speedPeg){
        switch (qNum) {
            case 1:
                return 0;
            case 2:
                int spaces = 0;
                for(int i = 0; i<speedDmoji.length();i++){
                    if(speedDmoji.charAt(i)== ' '){
                        spaces++;
                    }
                }
                int[] DmojiArray = new int[spaces+1] ;
                int[] pegArray = new int[spaces+1];
                int startIndex= 0;
                for(int i=0;i<speedDmoji.length();i++){
                    
                    if(i < speedDmoji.length()-1){
                        if (speedDmoji.charAt(i) == ' '){
                            DmojiArray.add(Integer.valueOf(speedDmoji.substring(startIndex,i)));
                        startIndex = i+1;
                        }
                        
                        
                    }
                    else{
                        DmojiArray.add(Integer.valueOf(speedDmoji.substring(startIndex)));
                        
                    }
                    
                }   
            default:
                return 0;
        }
        
        
        
    }
    
    
}
