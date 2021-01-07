using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Classes
{
    public class Person
    {
        public string Salutation { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public override string ToString() => $"{Salutation} {GivenName} {FamilyName}";
    }
}
