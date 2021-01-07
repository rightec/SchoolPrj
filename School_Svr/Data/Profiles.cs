using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Svr
{
    public class Profiles
    {
        public string Profilename { get; set; }

        public string Description { get; set; }

        //Navigational Property
        public ICollection<Persons> Persone { get; set; }

    }

}
