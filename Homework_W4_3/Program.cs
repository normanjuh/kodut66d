﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace Loop
{


    class Program
    {

        public static void Main(string[] args) {
            List<double> numbrid = new List<double> { 3, 5, 5, 7, 9, 15, 12, 19, 33};
            Console.WriteLine("Mean:");
            Console.WriteLine(findMean(numbrid));
            Console.WriteLine("Median:");
            Console.WriteLine(findMedian(numbrid));
            




        }

        public static double findMedian(List<double> nr)
        {
            nr.Sort();//sordib numbrid v2iksest suuremani
            int mitunumbrit = nr.Count; //loeb mitu numbrit on listis
            int kesk = mitunumbrit / 2;

            if (mitunumbrit % 2 == 0) //kontrollime kas list jagub kahega v ei
                {
                return ((nr[kesk - 1] + nr[kesk]) / 2);
                
                
            } // kui ei jagu siis v6tame 2 keskmist numbrit ja leiame nende keskmise ja returnime meetodi l6petamiseks
            else//kui jagub siis v6tame lihtsalt kesmise numbri ja returnime selle
                { return nr[kesk];  }
            



        }




        public static double findMean(List<double> nr)
        {
            int mitunumbrit = nr.Count; //checkime mitu numbrit kokku
            double summa = 0;

            foreach (double numba in nr)  //k'ime terve listi l'bi et numbrid kokku liita ja siis leiame nende kesmise, jagades summa numbrite arvuga ja returnime selle
            { 

                summa += numba;
            }
            double kesk = summa / mitunumbrit;
            return kesk;

        }
        
    }
}

   
        


