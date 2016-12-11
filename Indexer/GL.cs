using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class GL
    {
        private List<People> employees;
        public People this[string Name]
        {
            get
            {
                return employees.FirstOrDefault(em => em.LastName == Name);
            }
            private set
            {
                People o = employees.FirstOrDefault(em => em.LastName == Name);
                o = value;
            }
        }
        public GL()
        {
            employees = new List<People>()
            {
                new People { FirstName="Roman", LastName="Andriienko", Age=23},
                new People { FirstName="Slavko", LastName="Moiko", Age=27},
                new People { FirstName="Mariia", LastName="Vynychenko", Age=35},
                new People { FirstName="Volodymyr", LastName="Revenok", Age=28},
                new People { FirstName="Serhii", LastName="Krut", Age=31}
            };
        }
        
    }
}
