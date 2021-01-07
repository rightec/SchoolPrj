using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace School_Svr
{

    public static class PersonsServiceDB
    {

        public static void BasicQuery (string qName)
        {
            using (var db = new SchoolContext())
            {
                if (qName != "")
                {
                    IQueryable<Persons> people = db.Person
                        .Where(n => n.Name == qName);
                } else
                {
                    Console.WriteLine("No query execute");
                }
            }
        }
}
}


    
     