namespace ClassesTingSkating
{
    internal static class Skating
    {
        static string[] SkatingStuff = new string[5];
        private static int counter = 0;

        public static void AddSkatingStuff()
        {
            SkatingStuff[0] = "Rulleskøjter";
            SkatingStuff[1] = "Longboard";
            SkatingStuff[2] = "Løbehjul";
            SkatingStuff[3] = "Skateboard";
            SkatingStuff[4] = "Strygejern";


        }

        internal static void PrintArray()
        {
            foreach (string item in SkatingStuff)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < SkatingStuff.Length; i++)
            {
                Console.WriteLine(SkatingStuff[i] + " " + i);
            }

            while (counter < SkatingStuff.Length)
            {
                Console.WriteLine(SkatingStuff[counter]);
                counter++;
            }
        }
    }
}
