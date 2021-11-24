using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.CommonModel.Model.ProductOwner
{
  public  class StateModel :BaseClass
    {
      

        [Required]
        [MinLength(3, ErrorMessage = "Please enter atleast 3 char.")]
        [MaxLength(250, ErrorMessage = "Please enter 250 char only.")]
        public string StateName { get; set; }

        public int StateId { get; set; }
        [MaxLength(500, ErrorMessage = "Please enter 500 char only.")]
        public string StateDesc { get; set; }

        public string CountryId { get; set; }

        public string CountryName { get; set; }
    }
}
