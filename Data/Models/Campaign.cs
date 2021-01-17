using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Data.Models
{
    public class Campaign
    {
        [Key]
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public double Discount { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
