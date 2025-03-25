using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace Loop
{


    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of money:  ");      //kysime sisestust
            string raha = (Console.ReadLine());
            
            if (raha.Length < 4)
            {
                if (IsDigitsOnly(raha)){
                    GetMoneyInfo(raha); 
                }
            }


        }

        public static void GetMoneyInfo(string raha)
        {
            //Console.WriteLine(raha.Substring(1)); sentide jaoks seee
            //int rahanum = Convert.ToInt32(raha);
            Console.WriteLine(rahanum);
            Console.WriteLine(raha[0]);

            if ( Convert.ToInt32(raha[0]) > 1 ){ 
                Console.WriteLine(raha[1]+"");
            }





        
        }

        public static bool IsDigitsOnly(string str)
        {
            if (str.Length > 0)//if contains characters
            {
                foreach (char c in str)//assign character to c
                {
                    if (c < '0' || c > '9')//check if its outside digit range
                        return false;
                }
            }
            else//empty string
            {
                return false;//empty string 
            }

            return true;//only digits
        }


    }
}





