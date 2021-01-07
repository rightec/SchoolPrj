using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Svr
{
    public class Persons
    {
        public int PersonId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        //Navigational Property
        public Profiles Profile { get; set; }
    }

}
