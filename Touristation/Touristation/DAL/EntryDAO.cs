using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.BLL; 

namespace Touristation.DAL
{
    public class EntryDAO
    {
        public List<Entry> SelectByCompetition(int comId)
        {
            List<Entry> entry; 
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                entry = db.Entries.Where(e=> e.ComId == comId).Select(x => x).ToList();

            }
            return entry;
        }
    }
}