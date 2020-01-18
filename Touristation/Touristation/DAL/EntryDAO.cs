﻿using System;
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
    }
}