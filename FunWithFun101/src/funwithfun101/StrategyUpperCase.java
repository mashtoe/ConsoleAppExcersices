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
public class StrategyUpperCase implements TextDecorationStrategy
{

    @Override
    public String decorateText(String input)
    {
        return input.toUpperCase();
    }
    
}
