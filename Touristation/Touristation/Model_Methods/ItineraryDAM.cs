using Touristation.BLL;
using Touristation.DAL; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Touristation.Model_Methods
{
    public partial class Itinerary
    {

        public List<Itinerary> GetAllItems()
        {
            ItneraryDAO dal = new ItineraryDAO();
            return dal.SelectAll();
        }
        public Itinerary GetEmployeeById(string time)
        {
            ItineraryDAO dal = new ItineraryDAO();
            return dal.SelectById(time);
        }

        public int AddItinerary(Itinerary itn)
        {
            ItineraryDAO dal = new ItineraryDAO();
            int result = dal.Insert(itn);
            return result;
        } 
        public int UpdateItinerary(Itinerary itn)
        {
            ItineraryDAO dal = new ItineraryDAO();
            int result = dal.Update(itn);
            return result;

        }
    }
}