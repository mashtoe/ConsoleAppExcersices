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
public class TextDecorator
{
    private TextDecorationStrategy[] strategies;

    public TextDecorator(TextDecorationStrategy... strategies)
    {
        this.strategies = strategies;
    }

    public String applyStrategies(String text)
    {
        String decorated = text;
        for (TextDecorationStrategy strategy : strategies)
        {
            decorated = strategy.decorateText(decorated);
        }
        return decorated;
    }
    
    
}
