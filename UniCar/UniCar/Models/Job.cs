using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UniCar.Models
{
    public class Job
    {
        public Job()
        {

        }

        [DisplayName("Job Id")]
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("University Name")]
        public string University { get; set; }

        public string Description { get; set; }

        [DisplayName("Number of Applicants")]
        public int NoOfApplicants { get; set; }

        [DisplayName("Job Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("Interview Start Date")]
        public DateTime InterviewDate { get; set; }

        [DisplayName("Preferred Skills")]
        public string PreferredSkills { get; set; }

        public string Salary { get; set; }

        public string Website { get; set; }

        [DisplayName("Application Name")]
        public int ApplicationId { get; set; }

        [DisplayName("Employer Name")]
        public int EmployerId { get; set; }

    }
}
