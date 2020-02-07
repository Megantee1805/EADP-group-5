using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.BLL; 

namespace Touristation.DAL
{
    public class VoteDAO
    {
        public void Insert(Vote count)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Vote vote = new Vote();
                db.Votes.Add(count );
                db.SaveChanges(); 
            }
        }

        public Vote SelectByUserandEntry(int userId, int entryId)
        {
            Vote single; 
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                single = db.Votes.Where(v => v.UserId == userId && v.EntryId == entryId).FirstOrDefault(); 
            }
            return single; 
        }


        public void Delete(int id)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Vote vote = new Vote();
                db.Votes.Remove(db.Votes.Single(u => u.Id == id));
                db.SaveChanges();
            }
        }
    }
}