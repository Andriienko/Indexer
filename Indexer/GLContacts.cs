using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class GLContacts : Dictionary<string, People>
    {
        public void Add(string _LastName, string _FirstName, int _Age)
        {
            this[_LastName] = new People
            {
                FirstName = _FirstName,
                LastName = _LastName,
                Age = _Age
            };
        }
    }
    class GLContactBook
    {
        private GLContacts glcontacts;
        public People this[string Name]
        {
            get
            {
                return glcontacts[Name];
            }
            private set
            {
                People o = glcontacts[Name];
                o = value;
            }
        }
        public GLContactBook()
        {
            glcontacts = new GLContacts
            {
                {"Andriienko","Roman",23},
                {"Moiko","Roman",27},
                {"Vynychenko","Mariia",35},
                {"Revenok","Volodymyr",28},
                {"Krut","Serhii",31},
                {"Kohan","Ihor",26}
            };
        }
    }
}
