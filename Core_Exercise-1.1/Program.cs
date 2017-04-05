/*Create a Dictionary which holds the phone numbers of 5 people
Print out the contents of the dictionary
Remove the 3rd entry
Print out the contents of the Dictionary

What happens if you try to remove a "key 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_Exercise_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<string, double>();

            accounts.Add("John", 1.6);
            accounts.Add("Mary",2.4);
            accounts.Add("Fred",0.5);
            accounts.Add("Sue", 9.2);

            accounts["Fred"] += 1.0;
            accounts["Sue"] -= 1.0;

            if (accounts.ContainsKey("Sue"))
            {
                accounts.Remove("Sue");
            }

            //Console.WriteLine("John={0}\nMary={1}\nFred={2}\nSue={3}\n", accounts["John"], 
            //                  accounts["Mary"], accounts["Fred"], accounts["Sue"]);
            Console.WriteLine("John={0}\nMary={1}\nFred={2}\n", accounts["John"], 
                              accounts["Mary"], accounts["Fred"]);
        }
    }
    class Mapper
    {

    }
}
