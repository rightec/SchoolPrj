/**System.Collections.Generic
 * Contiene interfacce e classi che definiscono raccolte generiche che consentono agli utenti di creare raccolte 
 * fortemente tipizzate che forniscono indipendenza dai tipi e 
 * prestazioni migliori rispetto alle raccolte fortemente tipizzate non generiche.
 * */
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

// La direttiva using permette di usare i tipi di dato specificati nella libreria o pacchetto in cui sono definiti

//definisco lo scope dell'applicativo
namespace School_Svr
{
    /// <summary>
    /// 
    /// </summary>
    public class SchoolContext : DbContext  
    {/// <summary>
     /// Table Persons in DB school
     /// </summary>
        public DbSet<Persons> Person { get; set; }
        public DbSet<Profiles> Profile { get; set; }
        public DbSet<Employee> Employers { get; set; }
        public DbSet<Department> Dipartimenti { get; set; }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profiles>()
                .HasKey(pf => pf.Profilename);

            modelBuilder.Entity<Persons>()
                .HasKey(ps => ps.PersonId);

            modelBuilder.Entity<Employee>()
            .HasOne<Department>(e => e.Department)
            .WithMany(d => d.Employees);

            modelBuilder.Entity<Persons>()
           .HasOne<Profiles>(e => e.Profile)
           .WithMany(d => d.Persone);
        }
        #endregion
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=school.db");
        }


        public class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }

            //Navigational Property
            public Department Department { get; set; }
        }

        public class Department
        {
            public int DepartmentID { get; set; }
            public string Name { get; set; }

            //Navigational Property
            public ICollection<Employee> Employees { get; set; }
        }

    }

}
