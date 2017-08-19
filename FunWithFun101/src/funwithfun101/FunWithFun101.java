/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package funwithfun101;

import java.util.ArrayList;
import java.util.Random;

/**
 *
 * @author Bruger
 */
public class FunWithFun101 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        FunWithFun101 fun = new FunWithFun101();
        
        fun.StrategyPattern();
        
        
    }
    
    private void StrategyPattern()
    {
        String text = "apply strategies";
        TextDecorationStrategy uc = new StrategyUpperCase();
        TextDecorationStrategy wide = new StrategyWideSpacing();        
        TextDecorationStrategy altCaps = new StrategyAlternativeCaps();
        
        TextDecorator textDecorator = new TextDecorator(altCaps,wide,uc, new TextDecorationStrategy()
        {
            @Override
            public String decorateText(String input)
            {
                return input + ", som man siger.";
            }
        });
        System.out.println("Før: " + text);
        System.out.println("Efter: " + textDecorator.applyStrategies(text));
        System.out.println("Efter: " + textDecorator.applyStrategies("sup"));
    }
    
}
