using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Svr.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {

            // Look for any Profiles.
            if (context.Profile.Any())
            {
                return;   // DB has been seeded
            }

            var profileAdd = new Profiles[]
            {
                new Profiles { Profilename = "Studente",   Description = "User can write only its own course" },
                new Profiles { Profilename = "Viewer",   Description = "User has no write access at all" },
                new Profiles { Profilename = "Teacher",   Description = "User can write only a subpart of its students" },
                new Profiles { Profilename = "Manager",   Description = "User can write only a subpart of its students and its teachers" },
                new Profiles { Profilename = "Admin",   Description = "User has full access to all" },
            };

            context.Profile.AddRange(profileAdd);
             context.SaveChanges();          
        }
    }
}
