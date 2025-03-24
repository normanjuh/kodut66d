using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace Loop
{


    class Program
    {

        public static void Main(String[] args)
        {
                       
            Luger();

        }






        public static double method()
        {
            return 0;
        }

        static void Luger()
        {
            const string path1 = "koodid1.txt";     //defineerin filepathid
            const string path2 = "koodid2.txt";
            StreamReader reader1 = new StreamReader(path1);     //loon 2 streamreaderit
            StreamReader reader2 = new StreamReader(path2);

            //loon koodi alguste listi ja loen failist
            List<string> starts = new List<string>();


            string line = reader1.ReadLine();

            //chekin et rida pole tyhi
            while (line != null)
            {
                //Console.WriteLine(line);
                starts.Add(line);           //debugi jaoks
                line = reader1.ReadLine();
            }
            reader1.Close();



            //loon koodi l6ppude listi ja loen failist
            List<string> ends = new List<string>();


            string line2 = reader2.ReadLine();

            //chekin et rida pole tyhi
            while (line2 != null)
            {
                //Console.WriteLine(line2); //debugi jaoks
                ends.Add(line2);
                line2 = reader2.ReadLine();
            }
            reader2.Close();


            int reqLen = 11;

            //uus list vastuste jaoks
            List<string> vastused = new List<string>();
            //otsin vastavad paarid
            for (int i = 0; i < starts.Count; i++)
            {
                for (int o = 0; o < ends.Count; o++)
                {
                    if ((starts[i] + ends[o]).Length == reqLen)
                    {
                        vastused.Add(starts[i] + ends[o]);
                    }
                }
            }

            //prindin vastused
            Console.WriteLine("Vastused");
            foreach (string item in vastused)
            {
                Console.WriteLine(item);
            }









        }

        
        
    }
}

   
        


