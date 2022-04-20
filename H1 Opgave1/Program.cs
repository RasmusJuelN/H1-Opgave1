namespace H1Opgave1
{
    //Class
    class Program
    {
        //Fields (camelCase)
        static int i = 1;

        //Propeties (PascalCasing)



        ////Methods (PascalCasing)
        static void Main(string[] args) //Kan laves med "svm" + tabtab
        {




            //string lev = "bjarnes pølser";

            //myfirstmethod("cheese burger", lev);
            //myfirstmethod("pizza", lev);
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(celciustofahrenheit(i));
            }
            //double fahrenheit = celciustofahrenheit(7.8);
            //console.writeline(fahrenheit);
        }

        private static double celciustofahrenheit(double v) //access modifier --- returtype --- metodenavn --- parantes med parametre

        {
            double f = (v * 1.8) + 32;

            return f;
        }

        static void myfirstmethod(string fastfood, string lev)
        {
            Console.WriteLine(i + " " + fastfood + " (" + lev + ")");
            Console.WriteLine($"{i} {fastfood} ({lev})");
            i++;
        }
    }
}
