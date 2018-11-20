/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package randomapp;
import java.util.*;
/**
 *
 * @author gurla_000
 */
public class RandomApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      car bugatti = new car(144,"D");
      System.out.println(bugatti.speed);
      bugatti.brake();
      System.out.println(bugatti.speed);
      
    }
    
static class car {
    
    int speed;
    String gear;
    
    public car(int velocity, String gearType){
        speed = velocity;
        gear = gearType;
    }

    public void brake(){
    speed = 0;
}
    public void park(){
    gear = "P";
}  
    
}
}

