using System;
using System.Collections.Generic;
using System.Linq;

namespace TP9.Helpers
{
    static public class ConversorDeMorse
    {
        static Dictionary<char, string> DictMorse = new Dictionary<char, string>()
        {
            {'a' , ".-"},
            {'b' , "-..."},
            {'c' , "-.-."},
            {'d' , "-.."},
            {'e' , "."},
            {'f' , "..-."},
            {'g' , "--."},
            {'h' , "...."},
            {'i' , ".."},
            {'j' , ".---"},
            {'k' , "-.-"},
            {'l' , ".-.."},
            {'m' , "--"},
            {'n' , "-."},
            {'o' , "---"},
            {'p' , ".--."},
            {'q' , "--.-"},
            {'r' , ".-."},
            {'s' , "..."},
            {'t' , "-"},
            {'u' , "..-"},
            {'v' , "...-"},
            {'w' , ".--"},
            {'x' , "-..-"},
            {'y' , "-.--"},
            {'z' , "--.."},
            {'1' , ".---"},
            {'2' , "..---"},
            {'3' , "...--"},
            {'4' , "....-"},
            {'5' , "....."},
            {'6' , "-...."},
            {'7' , "--..."},
            {'8' , "---.."},
            {'9' , "----."},
            {'0' , "-----"}
            };

        public static String MorseATexto(String enMorse)
        {
            string[] palabras = enMorse.Split('/');
            string traduccion="";

            foreach (string palabra in palabras)
            {
                foreach(string letra in palabra.Split(' '))
                {
                    traduccion+=DictMorse.FirstOrDefault(x => x.Value.Equals(letra)).Key;
                }
                traduccion += " ";
            }

            return traduccion;
        }
            
        public static String TextoAMorse(String aMorse)
        {
            string[] palabras = aMorse.Split(' ');
            string traduccion = "";

            foreach (string palabra in palabras)
            {
                foreach (char letra in palabra.ToLower())
                {
                    traduccion += DictMorse[letra];
                    traduccion += " ";
                }
                traduccion += "/ ";
            }

            return traduccion;
        }
    }
}
