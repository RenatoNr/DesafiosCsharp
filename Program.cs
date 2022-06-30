using System.Diagnostics;
using System.ComponentModel;

namespace Desafios
{
   public  class Desafios
    {
         public static void DrawPyramid(char symbol, int height)

        {
            if (height < 1) return;

            for (int i = 1; i <= height; i++)
            {
                string line = new String(symbol, (2*i -1));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)+i) + "}", line));
            }

        }

        public static void ConvertToHex(string str)
        {
            char[] letters = str.ToCharArray();
            string hexString = "";

            foreach (var letter in letters)
            {
                int converted = Convert.ToInt32(letter);
                hexString += new String($" {converted:X}").ToLower();
            }
            Console.WriteLine("A String ** {0} ** convertida para Hexadecimal é: {1}",str, hexString);
        }

    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pyramid");

            Desafios.DrawPyramid('#',5);

            Desafios.ConvertToHex("Marty Poppinson");

            
            
        }
    }
}