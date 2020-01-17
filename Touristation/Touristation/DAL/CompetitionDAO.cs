using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.BLL; 

namespace Touristation.DAL
{
    public class CompetitionDAO
    {

        public List<Competiton> SelectByDate()
        {
            List<Competiton> available;
            DateTime today = DateTime.Now;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitons.Where(c => c.endDate >= today).Select(x => x).ToList();

            }

            return available;
        }

        public Competiton SelectById(int id)
        {
            Competiton current;

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                current = db.Competitons.Where(c => c.Id == id).FirstOrDefault();

            }
            return current;
        }

        public Competiton SelectByTitle(string title)
        {
            Competiton available;
            

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitons.Where(c => c.name == title).FirstOrDefault(); 

            }

            return available;
        }

        public void Insert(Competiton com)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Competiton newcom = new Competiton();
                db.Competitons.Add(com);
                db.SaveChanges(); 
            }
            
        }

        public void Update(Competiton com)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Competiton updateCome = new Competiton(); 
                Competiton check = db.Competitons.Where(c => c.Id == com.Id).FirstOrDefault();
                if (check != null)
                {
                    check.name = com.name;
                    check.description = com.description;
                    check.entriesNo = com.entriesNo;
                    check.endDate = com.endDate;
                    check.startDate = com.startDate;
                    check.winners = com.winners;
                    db.SaveChanges(); 
                }
            }
        }
        
    }
    }
