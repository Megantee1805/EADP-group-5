using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.BLL; 

namespace Touristation.DAL
{
    public class CompetitionDAO
    {

        public List<Competition> SelectByDate(int userId)
        {
            List<Competition> available;
            DateTime today = DateTime.Now;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitions.Where(c => c.endDate >= today && c.judges != userId && c.isDeleted == false).Select(x => x).ToList();

            }

            return available;
        }

        public List<Competition> SelectByJudge(int userId)
        {
            List<Competition> available;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitions.Where(c => c.judges == userId && c.isDeleted == false).Select(x => x).ToList();

            }

            return available;
        }

        public List<Competition> SelectAll()
        {
            List<Competition> available;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitions.Select(x => x).ToList();

            }

            return available;
        }

        public List<Competition> SelectFinishedCom()
        {
            List<Competition> available;
            DateTime today = DateTime.Now;
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                available = db.Competitions.Where(c => c.endDate <= today && c.isDeleted == false).Select(x => x).ToList();

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
                    check.winners = com.winners; 
                    check.entriesNo = com.entriesNo;
                    check.endDate = com.endDate;
                    check.startDate = com.startDate;
                    check.JudgingCriteria = com.JudgingCriteria;
                    check.prize = com.prize; 
                    db.SaveChanges();
                }
            }


        }


        public void Delete(int id)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Competition check = db.Competitions.Where(c => c.Id == id).FirstOrDefault();
                if (check != null)
                {
                    check.isDeleted = true; 
                    db.SaveChanges();
                }
                
            }
        }

    }
    }
