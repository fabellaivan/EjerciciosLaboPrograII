using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorString
{
    public static class stringclas
    {
        public static int ContadorVocales(this string text)
        {
            if(string.IsNullOrEmpty(text))
            {
                return 0;
            }
            int retorno = 0;
            text = text.ToLower();
            
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char c in text)
            {
                if(vocales.Contains(c))
                {
                    retorno++;
                }
            }
            return retorno;
        }

        public static int ContadorCaracteres(this string text,char caracter)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }
            int retorno = 0;
            text = text.ToLower();

            foreach(char c in text)
            {
                if(caracter == c)
                {
                    retorno++;
                }
            }
             
            return retorno;
        }
    }
}
