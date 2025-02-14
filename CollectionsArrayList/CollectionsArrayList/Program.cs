using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Collections_by_MaheshSir
{
    class Example_01
    {
        static void Main(string[] args)
        {
            ArrayList Countries = new ArrayList();
            Countries.Add("India");
            Countries.Add("South Africa");
            Countries.Add("New Zealand");
            Countries.Add("Sri Lanka");
            
        Countries.Add("Singapore");
            Countries.Add("Malaysia");
            Countries.Add("Dubai");
            Countries.Add("Canada");
            Console.WriteLine("List of Country names are");
            Console.WriteLine("--------------------------");
            foreach (object C in Countries)
                Console.WriteLine(C);
            Console.ReadKey();
        }
    } 
}