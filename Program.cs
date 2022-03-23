using System;
using System.Collections;

namespace Hashtabledemo
{
  class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table.Add(1, "to be");
            table.Add(2, "not to be");
            table.Add(3, "or");
            //table.Add(4, "not");

            foreach(DictionaryEntry ele in table)
            {
                Console.WriteLine(ele.Key + "-" + ele.Value);
            }
            //Console.WriteLine("---------");

            //Console.WriteLine(table.ContainsKey(3));

            Console.WriteLine("----------");
            Console.WriteLine(table[1]);

        }
    }
}