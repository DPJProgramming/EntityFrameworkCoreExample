using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity_Framework_core_example
{
    public class Student{

        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }


    }
}

