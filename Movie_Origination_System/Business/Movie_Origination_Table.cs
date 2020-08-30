using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Origination_System.Business
{
    public class Movie_Origination_Table
    {
        [Key]

        public int Movie_Origination_ID { get; set; }
        public int Movie_ID { get; set; }
        public Movie_details Movie_details { get; set; }

        public int Movie_Producer_ID { get; set; }
        public Producer_details Producer_details { get; set; }

        public int Movie_Director_ID { get; set; }
        public Director_details Director_details { get; set; }
    }
}
