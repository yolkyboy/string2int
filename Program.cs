using System;

namespace String2Int
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            //***Getting an input from the user
            Console.WriteLine("Enter something: ");
            input = Console.ReadLine();
            //***Looping every character from the input
            for (int i = 0; i < input.Length; i++)
                {
                    //***Convert each character to ASCII code
                    int ASCnum = input[i];
                    //***if the ASCII code is more than or equal to 48, and less than or equal to 57, Do the calculation
                    if(ASCnum >= 48 && ASCnum <= 57)
                    {
                        int Vnum;
                       //***Get the ASCII code from i character, and minus with 48 to make a result as integer
                        Vnum = ASCnum - 48;
                        Console.Write(Vnum);
                    }
                }
        }
    }
}