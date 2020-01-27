using System;
using System.Collections.Generic;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using Touristation.BLL;

namespace Touristation.DAL
{
    public class ItineraryDAO
    {
        public List<Itinerary> SelectAll()
        {

            using (TouristationEntityModel db = new TouristationEntityModel())
            { 

                List<Itinerary> itnList = new List<Itinerary>();
                itnList = db.Itineraries.Select(x => x).ToList(); 
                return itnList;
            }

           
        }

        /* internal int Insert(Itinerary itn)
        {
            throw new NotImplementedException();
        }

    */ 

        public void Insert(Itinerary itn)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                db.Itineraries.Add(itn);
                db.SaveChanges();
            }
        }
        public Itinerary SelectById(int id)
        {

            using (TouristationEntityModel db = new TouristationEntityModel())
            {

                Itinerary itn;
                itn = db.Itineraries.Where(i => i.Id == id).FirstOrDefault();
                return itn;
            }
        }
        public void Update(Itinerary itn)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Itinerary updateItn = new Itinerary();
                Itinerary check = db.Itineraries.Where(i => i.Id == itn.Id).FirstOrDefault(); 
                if (check != null)
                {
                    check.NamePlace = itn.NamePlace;
                    check.Location = itn.Location;
                    check.Time = itn.Time;
                    check.Date = itn.Date;
                    db.SaveChanges(); 
                }
            }
        }

        public void Delete(int id)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                Itinerary itn = new Itinerary();
                db.Itineraries.Remove(db.Itineraries.Single(e => e.Id == id));
                db.SaveChanges();
            }
        }
    }
}

     