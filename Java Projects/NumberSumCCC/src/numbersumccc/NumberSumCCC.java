/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package numbersumccc;
import java.util.*;
/**
 *
 * @author gurla_000
 */
public class NumberSumCCC {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int weight = input.nextInt();
        int numOfCarts = input.nextInt();
        int cartWeight = 0;
        
        ArrayList<Integer> carts = new ArrayList();
        for (int i=1;i<=numOfCarts;i++){
            carts.add(input.nextInt());
        }
        
        if(carts.get(0) > weight){
            System.out.println(0);
        }
        else if((carts.get(0) + carts.get(1)) > weight){
            System.out.println(1);
        }
        else if((carts.get(0) + carts.get(1) + carts.get(2)) > weight){
            System.out.println(2);
        }
        else if((carts.get(0) + carts.get(1) + carts.get(2) + carts.get(3)) > weight){
            System.out.println(3);
        }
        else{
            for(int i=0;i<numOfCarts-3;i++){
                cartWeight = carts.get(i) + carts.get(i+1) + carts.get(i+2) + carts.get(i+3);
                
                if(cartWeight > weight){
                    System.out.println(i+3);
                }
                else if(cartWeight == weight){
                    System.out.println(i+4);
                }
                else if(i==numOfCarts-4){
                    System.out.println(numOfCarts);
                }
            }
        }
        
        
        
    }
    
    
}
