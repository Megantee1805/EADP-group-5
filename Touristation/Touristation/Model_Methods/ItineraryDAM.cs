using Touristation.BLL;
using Touristation.DAL; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Touristation.BLL
{
    public partial class Itinerary
    {

        public List<Itinerary> GetAllItems()
        {
            ItineraryDAO dal = new ItineraryDAO();
            return dal.SelectAll();
        }
        public Itinerary GetEmployeeById(int time)
        {
            ItineraryDAO dal = new ItineraryDAO();
            return dal.SelectById(time);
        }

        public void AddItinerary(Itinerary itn)
        {
            ItineraryDAO dal = new ItineraryDAO();
            dal.Insert(itn);
        } 
        public void UpdateItinerary(Itinerary itn)
        {
            ItineraryDAO dal = new ItineraryDAO();
            dal.Update(itn);
        }

        public void RemoveItinerary(int id)
        {
            ItineraryDAO dal = new ItineraryDAO();
            dal.Delete(id);
        }

    }
}

