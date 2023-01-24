using System;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_core_example
{
    //EF Core Getting started
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/install
    public class StudentContext : DbContext {

        public StudentContext()
        {

        }

        //Database = desired name of database
        //server = server we are connectinig to localdb is included with visual studio
        //Trusted_Connection - indicates that our windows account should be used
        protected override void OnConfigure(DbContextOptionsBuilder options) {
            DbContextOptionsBuilder.UseSqlServer("Server = (localdb\\mssqllocaldb;" +
                                                    "Database=EFCoreExample;" +
                                                    "Trusted_Connection=True;");
        }
    }
}

