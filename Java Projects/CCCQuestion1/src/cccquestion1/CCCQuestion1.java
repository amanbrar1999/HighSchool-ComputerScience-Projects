/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cccquestion1;
import java.util.*;
/**
 *
 * @author gurla_000
 */
public class CCCQuestion1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        int[] swiftsRuns = new int[N];
        int[] sephamoreRuns = new int[N];
        for(int i=0;i<N;i++){
            if(i==0){
                swiftsRuns[i] = input.nextInt();
            }
            else{
            swiftsRuns[i] = swiftsRuns[i-1]+input.nextInt();
            }
        }
        for(int i=0;i<N;i++){
            if(i==0){
                sephamoreRuns[i] = input.nextInt();
            }
            else{
            sephamoreRuns[i] = sephamoreRuns[i-1]+input.nextInt();
            }
        }
        int K = 0;
        
        for(int i=N-1;i>=0;i--){
  
            if(swiftsRuns[i] == sephamoreRuns[i]){
                K = i+1;
                break;
            }
        }
        
        System.out.println(K);
    }
    
}
