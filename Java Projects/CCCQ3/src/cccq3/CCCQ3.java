/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cccq3;
import java.util.*;
/**
 *
 * @author gurla_000
 */
public class CCCQ3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        
        int[] boards = new int[N];
        
        for(int i=0;i<N;i++){
            boards[i]=input.nextInt();
        }
        Arrays.sort(boards);
        
        int length = 1;
        
        ArrayList sums = new ArrayList();
        for(int i=0;i<N;i++){
            for(int k=0;k<N;k++){
                if(i != k){
                    sums.add(boards[i] + boards[k]);
                }
            }
        }
        
        for(int i=0;i<sums.size();i++){
            for(int k=0;k<N;k++){
                
                if(i!=k){
                    if(sums.get(i) == sums.get(k)){
                        
                    }
                }
            }
        }
        
        
        
        
        
        
        
    }
    
}
