using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------Simple-----------------------*/
            GL corp = new GL();
            People p = corp["Moiko"];
            if(p!=null)
                Console.WriteLine( p.FirstName+"\t"+p.LastName+"\t"+p.Age);
            else
                Console.WriteLine("Not Found - 404");

            /*----------------Dictionary-----------------------*/
            GLDictionary o = new GLDictionary();
            People man = corp["Revenok"];
            if (man != null)
                Console.WriteLine(man.FirstName + "\t" + man.LastName + "\t" + man.Age);
            else
                Console.WriteLine("Not Found - 404");

            /*----------------ModernDictionary-----------------------*/
            GLContactBook cbook = new GLContactBook();
            People contact = cbook["Andriienko"];
            if (contact != null)
                Console.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.Age);
            else
                Console.WriteLine("Not Found - 404");

        }
    }
}
