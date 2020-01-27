using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.BLL; 

namespace Touristation.DAL
{
    public class CompetitionDAO
    {

        public List<Competition> SelectByDate()
        {
            List<Competition> available;
            DateTime today = DateTime.Now;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitions.Where(c => c.endDate >= today).Select(x => x).ToList();

            }

            return available;
        }

        public List<Competition> SelectFinishedCom()
        {
            List<Competition> available;
            DateTime today = DateTime.Now;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitions.Where(c => c.endDate <= today).Select(x => x).ToList();

            }

            return available;
        }

        public Competition SelectById(int id)
        {
            Competition current;

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                current = db.Competitions.Where(c => c.Id == id).FirstOrDefault();

            }
            return current;
        }

        public Competition SelectByTitle(string title)
        {
            Competition available;
            

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitions.Where(c => c.name == title).FirstOrDefault(); 

            }

            return available;
        }

        public void Insert(Competition com)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Competition newcom = new Competition();
                db.Competitions.Add(com);
                db.SaveChanges(); 
            }
            
        }

        public void Update(Competition com)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Competition updateCome = new Competition(); 
                Competition check = db.Competitions.Where(c => c.Id == com.Id).FirstOrDefault();
                if (check != null)
                {
                    check.name = com.name;
                    check.description = com.description;
                    check.entriesNo = com.entriesNo;
                    check.endDate = com.endDate;
                    check.startDate = com.startDate;
                    db.SaveChanges(); 
                }
            }


        }

        public void Delete(int id)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Competition com = new Competition();
                db.Competitions.Remove(db.Competitions.Single(c => c.Id == id));
                db.SaveChanges();
            }
        }

    }
    }
