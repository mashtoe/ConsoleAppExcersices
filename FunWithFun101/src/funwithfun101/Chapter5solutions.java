/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package funwithfun101;

/**
 *
 * @author Bruger
 */
public class Chapter5solutions 
{
   public void powerOfTwoInRange()
   {
       
       
              
       for (int i = 0; i < 21; i++) 
       {
           double sum = Math.pow(2, i);
           System.out.println("2^" + i + " = " + sum);
       }
   }
   
   public int e(int a, int b)
   {
       int sum = 0;
       
       for (int i = a; i <= b; i++) 
       {
           if (a%2 != 0) 
           {
               sum += i;
               System.out.println(sum);
           }
       }
       return sum;
   }
}
