using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int prodottomax = 0;

        int length = digits.Length;

        if(span > length)
            throw new System.ArgumentException();

        if(span < 0)
            throw new System.ArgumentException();

        if( span==0 )
            return 1;

        
        char[] array = digits.ToCharArray();

        for (int j = 0; j <= length-span; j++)
        {
            int prodotto = 1;
            int supp = j;

            for (int x = 0; x < span; x++)
            {
                prodotto = prodotto * (array[supp]-48);
                supp = supp + 1;
            }
                
                if(prodotto > prodottomax)
                {
                    prodottomax = prodotto;
                }
        }

        for (int i = 0; i < length; i++)
        {
            if(char.IsLetter(array[i]))
            {
                throw new System.ArgumentException();                
            }
        }

        if(span > length)
            throw new System.ArgumentException();

        if(span < 0)
            throw new System.ArgumentException();

        if( span==0 )
            return 1;

        return prodottomax;
    }
}