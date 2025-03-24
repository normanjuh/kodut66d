using System;

namespace Loop
{


    class ForLoop
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter amount of money:  ");      //kysime sisestust
            double raha = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest rate:  ");
            double intress = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of years:  ");
            int aastad = Int32.Parse(Console.ReadLine());

            double d = FindCompoundInterest(raha, intress, aastad);
            Console.WriteLine("Resulting money: " + d.ToString());

        }






        public static double FindCompoundInterest(double initial, double interest, int years)
        {
            for (int i = 1; i <= years; i++)
            {
                initial = initial * (1 + (interest / 1));
                
            }



            return initial;
        }
    }
}