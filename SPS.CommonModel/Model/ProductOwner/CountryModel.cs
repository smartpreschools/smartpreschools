using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SPS.CommonModel.Model.ProductOwner
{
    public class CountryModel : BaseClass
    {
        [Required]
        [MinLength(3,ErrorMessage ="Please enter atleast 3 char.")]
        [MaxLength(250, ErrorMessage = "Please enter 250 char only.")]
        public string CountryName { get; set; }

        public int CountryId { get; set; }
        [MaxLength(500, ErrorMessage = "Please enter 500 char only.")]
        public string CountryDesc { get; set; }
    }
}
