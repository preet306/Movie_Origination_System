using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Origination_System.Business
{
    public class Producer_details
    {
        [Key]

        public int Movie_Producer_ID { get; set; }
        public string Movie_Producer_Name { get; set; }
        public string Movie_Producer_Email { get; set; }
        public string Movie_Producer_Mobile { get; set; }
        public string Movie_Producer_Occupations { get; set; }
    }
}
