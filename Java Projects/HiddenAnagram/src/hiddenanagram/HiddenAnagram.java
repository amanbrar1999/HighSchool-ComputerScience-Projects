/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hiddenanagram;

/**
 *
 * @author gurla_000
 */
public class HiddenAnagram {

    public static void main(String args[]){
    	
    	
    	System.out.println(isItAHiddenAnagram("given","****g"));
    	
    }
    
    public static boolean isItAHiddenAnagram(String givenWord,String possibleAnagram ){
    	boolean isAnagram = true;
    	
    	char[] referenceWord = givenWord.toCharArray();
    	char[] check = possibleAnagram.toCharArray();
    	
    	for(int i=0; i<referenceWord.length;i++){
    		String character = referenceWord[i]+"";
    		inner: for(int x=0;x<check.length;x++){
    			String nextCharacter = check[x]+"";
    		
    			if(character.equals(nextCharacter)){
    				check[x] = '0';
    				referenceWord[i] = '0';
    				break inner;
    			}
    		}    			
    	}
    	
    	for(int i=0;i<check.length;i++){
    		if(check[i] != '0' && check[i] != '*'){
    			isAnagram = false;
                        break;
    		}
    	}
    	return isAnagram;
    }
    
}
