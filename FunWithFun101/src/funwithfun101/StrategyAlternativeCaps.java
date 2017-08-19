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
public class StrategyAlternativeCaps implements TextDecorationStrategy
{

    @Override
    public String decorateText(String input)
    {
        char[] charsInString = input.toCharArray();
        String decoratedString = "";
        int i = 0;
        for (char c : charsInString)
        {
            if (i % 2 == 0)
            {
                decoratedString += Character.toString(c).toLowerCase();
            }
            else
            {
                decoratedString += Character.toString(c).toUpperCase();
            }
            i++;
        }
        return decoratedString;
    }
    
}
