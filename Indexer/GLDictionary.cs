using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class GLDictionary
    {
        private Dictionary<string, People> employees;
        public People this[string Name]
        {
            get
            {
                return employees[Name];
            }
            private set
            {
                People o = employees[Name];
                o = value;
            }
        }
        public GLDictionary()
        {
            employees = new Dictionary<string, People>()
            {
                {"Andriienko",  new People { FirstName="Roman", LastName="Andriienko", Age=23} },
                {"Moiko", new People { FirstName="Slavko", LastName="Moiko", Age=27} },
                {"Vynychenko", new People { FirstName = "Mariia", LastName = "Vynychenko", Age = 35 }},
                {"Revenok",  new People { FirstName="Volodymyr", LastName="Revenok", Age=28} },
                {"Krut", new People { FirstName="Serhii", LastName="Krut", Age=31}}
            };
        }

    }
    
}

