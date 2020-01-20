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

        public List<Entry> SelectByUser(int userId)
        {
            List<Entry> entry;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                entry = db.Entries.Where(e => e.UserId == userId).Select(x => x).ToList();

            }
            return entry;
        }

        public Entry SelectById(int id)
        {
            Entry entry;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                entry = db.Entries.Where(e => e.Id == id).FirstOrDefault();

            }
            return entry;
        }

        public List<Entry> SelectAll()
        {
            List<Entry> entries;

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                entries = db.Entries.Select(x => x).ToList();

            }
            return entries;
        }

        public void Insert(Entry ent)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                db.Entries.Add(ent);
                db.SaveChanges();
            }

        }

        public void Update(Entry ent)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Entry updateEnt = new Entry();
                Entry check = db.Entries.Where(c => c.Id == ent.Id).FirstOrDefault();
                if (check != null)
                {
                    check.name = ent.name;
                    check.description = ent.description;
                    check.fileLink = ent.fileLink;
                    check.rank = ent.rank;
                    check.score = ent.rank;
                    check.votes = ent.votes; 
                    db.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Entry entry = new Entry();
                db.Entries.Remove(db.Entries.Single(e => e.Id == id));
                db.SaveChanges();
            }
        }
    }
}