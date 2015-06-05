using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTiere_Angularjs_codefirst_Simply.Domain.Models
{
    //Data table mapper pattern
    public class Person
    {
       //PK Identity field
        public int ID { get; set; }
        //Person name field
        public string Name { get; set; }
        //Age Field
        public int Age { get; set; }
        //DOB Field
        public DateTime DOB { get; set; }
        //Email Field
        public string Email { get; set; }
        //Cell Field
        public string Cell { get; set; }

    }
}
