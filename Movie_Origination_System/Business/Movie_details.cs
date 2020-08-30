using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Origination_System.Business
{
    public class Movie_details
    {
        [Key]

        public int Movie_ID { get; set; }
        public string Movie_Name { get; set; }
        public string Movie_Release_Date { get; set; }
        public string Movie_Language { get; set; }
        public string Movie_Running_Time { get; set; }

    }
}
