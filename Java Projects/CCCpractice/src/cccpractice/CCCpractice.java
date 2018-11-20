/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cccpractice;
import java.util.*;
/**
 *
 * @author gurla_000
 */
public class CCCpractice {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner input = new Scanner(System.in);
    int currentYear = input.nextInt()+1;
    Boolean isUnique = false;
    big: while(isUnique==false){
        char[] year = String.valueOf(currentYear).toCharArray();
        second: for(int i=0;i<year.length;i++){
            for(int k=0;k<year.length;k++){
                if(i!=k && (String.valueOf(year[i]).equals(String.valueOf(year[k])))){
                    isUnique = false;
                    break second;
                }
                if(i==year.length-1 && i==k){
                    isUnique = true;
                    break big;
                }
            }
            
        }
    currentYear++;
    }
    System.out.println(currentYear);
    }
    
    
    
}
