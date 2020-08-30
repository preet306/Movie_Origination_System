using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Origination_System.Business
{
    public class Director_details
    {
        [Key]

        public int Movie_Director_ID { get; set; }
        public string Movie_Director_Name { get; set; }
        public string Movie_Director_Email { get; set; }
        public string Movie_Director_Mobile { get; set; }
        public string Movie_Director_Occupations { get; set; }
    }
}
