using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UniCar.Models
{
    public class WorkHistory
    {
        public WorkHistory() { 
        
        }
        public int Id { get; set; } 

        [DisplayName("Company or Organization")]
        public String Organization { get; set;}

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [DisplayName("Current Job")]
        public Boolean IsCurrent { get; set; }

        [DisplayName("Work Description")]
        public String WorkDescription { get; set; }


    }
}
