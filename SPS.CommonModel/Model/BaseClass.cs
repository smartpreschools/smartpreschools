using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.CommonModel.Model
{
    public class BaseClass
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Status { get; set; } 
    }
}
