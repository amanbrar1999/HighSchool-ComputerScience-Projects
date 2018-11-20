/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cccq2;
import java.util.*;
/**
 *
 * @author gurla_000
 */
public class CCCQ2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        int[] tides = new int[N];
        
        for(int i=0;i<N;i++){
            tides[i] = input.nextInt();
        }
        
        Arrays.sort(tides);
        
        int seperation = 0;
        
        if(tides.length%2==0){
            seperation = tides.length/2 -1;
            
            for(int i=0;i<=seperation;i++){
            System.out.print(tides[seperation - i] + " " + tides[i+seperation+1] + " ");
        }
        }
        else{
            seperation = tides.length / 2;
            for(int i=0;i<seperation;i++){
                
            System.out.print(tides[seperation - i] + " " + tides[1+i+seperation] + " ");
            
        }
            System.out.print(tides[0]);
        }
        
        
        
    }
    
}
