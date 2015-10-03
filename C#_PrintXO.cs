//create the pattern of a chess board that is 8 x 8.  Use X and O to represent the squares.
//Create the appropriate nested looping structure to output the characters in an 8 x 8 grid on the screen 
//using Console.Write() or Console.WriteLine() as appropriate.
//Include a decision structure to ensure that alternate rows start with opposite characters as a real chess 
//board alternates the colors among rows.

//This is what your output should look like.

//XOXOXOXO
//OXOXOXOX
//XOXOXOXO
//OXOXOXOX
//XOXOXOXO
//OXOXOXOX
//XOXOXOXO
//OXOXOXOX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//author Nadiia Semenchuk

namespace ModuleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Grid
            char value = 'X';

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(" ");

                if (value == 'X')
                {

                    for (int j = 0; j < 4; j++)
                    {
                        value = 'X';
                        Console.Write(value);
                        value = 'O';
                        Console.Write(value);
                    }
                }
                else if (value == 'O')
                {
                    for (int j = 0; j < 4; j++)
                    {
                        value = 'O';
                        Console.Write(value);
                        value = 'X';
                        Console.Write(value);

                    }

                }
               
            }
            Console.Read();
            #endregion
        }
    }
}
