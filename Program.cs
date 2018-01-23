using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            //Define a Dictionary that contains information about several members of your family.

            Dictionary<string, Dictionary <string, string>> myFamily = new Dictionary<string, Dictionary <string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Katrina"},
                {"age", "43"}
            });

            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Earline"},
                {"age", "58"}
            });

            myFamily.Add("niece", new Dictionary<string, string>(){
                {"name", "Ermani"},
                {"age", "11"}
            });

            //Next, iterate over each item in myFamily (a dictionary of dictionaries) and produce the output: "Krista is my sister and is 42 years old".

           foreach (var kvp in myFamily){

            //    Console.WriteLine(kvp.Key);

               foreach (var kvp2 in kvp.Value){
                   Console.WriteLine("{0},{1}", kvp2.Key, kvp2.Value);
                //    Console.WriteLine(kvp2.ToString());
               }
           }
        }
    }
}
