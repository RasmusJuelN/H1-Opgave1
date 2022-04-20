using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Rugby
{
    internal class Tools
    {

        private static int counter;
        internal static void PrintArray(string[] Names)
        {
            foreach (string player in Names)
            {
                Console.WriteLine(player);
            }
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine("Player number " + i + " Name: " + Names[i]);
                
            }
            while (counter < Names.Length)
            {
                Console.WriteLine(Names[counter]);
                counter++;
            }
        }
    }
}
