using System;
using System.Collections.Generic;
using System.Linq;
using EntityUppgift.Data;
using EntityUppgift.Data.Models;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Managers
{
    public class CampaignManager
    {
        public Campaign GetCampaignById(int id)
        {
            using (var db = new EntityUppgiftContext())
            {
                var campaign = db.Campaign.Find(id);
                return campaign;
            }
        }
        public void CreateCampaign(Campaign campaign)
        {
            using (var db = new EntityUppgiftContext())
            {
                db.Campaign.Add(campaign);
                db.SaveChanges();
            }
        }
    }
}
