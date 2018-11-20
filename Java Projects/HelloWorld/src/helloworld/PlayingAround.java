/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package HelloWorld;
import java.util.*;
import java.io.*;
/**
 *
 * @author gurla_000
 */
public class PlayingAround {

    /**
     * @param args the command line arguments
     * @throws java.io.IOException
     */
    public static void main(String[] args) throws IOException {
        // TODO code application logic here
        BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
        int side1 = Integer.parseInt(input.readLine());
        int side2 = Integer.parseInt(input.readLine());
        int side3 = Integer.parseInt(input.readLine());
        
        if(side1 == 60 && side2==60 && side3==60){
            System.out.println("Equilateral");
        }
        else if((side1+side2+side3==180) && (side1==side2 || side1==side3 || side2==side3))
        {
            System.out.println("Isosceles");
        }
        else if(side1+side2+side3==180)
        {
            System.out.println("Scalene");
        }
        else{
            System.out.println("Error");
        }
       
        
        
    }
    
}
