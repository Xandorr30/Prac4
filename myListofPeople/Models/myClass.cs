using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace myListofPeople.Models
{
	public class myClass
	{
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }

        [Display(Name = "Delete")]
        public string delete { get; set; }
    }
}