/* Generate a Hash table with 5 Currencies and their conversion rates to pounds (you can make those rates up!)
Print the hash table contents
Change one of the values associated with a currency
Print the table again
*/ 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_Exercise_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashTable = new Hashtable();
            myHashTable.Add("Fiat", "BN61RHY");
            myHashTable.Add("Ford", "LE66FEU");
            myHashTable.Add("Kia", "VE59DEW");

            foreach (DictionaryEntry de in myHashTable)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}
