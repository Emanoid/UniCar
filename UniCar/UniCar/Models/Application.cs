using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UniCar.Models
{
    public class Application
    {
        public Application() {

        }

        [DisplayName("Application Id")]
        public int Id {get; set;}

        [DisplayName("Full Name")]
        public String Name { get; set; }

        [DisplayName("Phone Number")]
        public String Phone { get; set; }

        public String Email { get; set; }

        [DisplayName("Personal Website")]
        public String Website { get; set; }

        [DisplayName("Link to Credentials")]
        public String CredentialLink { get; set; }

        [DisplayName("Work History")]
        public WorkHistory WorkHistory { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DOB { get; set; }

        public String Disclaimers { get; set; }

        public String Consent { get; set; }

        [DisplayName("Job Name")]
        public int JobId { get; set; }
    }

    
}
