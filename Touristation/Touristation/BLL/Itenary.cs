using Itenary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itenary.BLL
{
    public class ItenaryX
    {

        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }

        public ItenaryX()
        {

        }
        public ItenaryX(string name, string time, DateTime doe, string location)
        {

            Name = name;
            EventDate = doe;
            Time = time;
            Location = location;

        }

        public ItenaryX(DateTime doe, string time, string name, string location)
        {
            Time = time;
            Name = name;
            Location = location;
        }

        public int AddItenary()
        {
            ItenaryDAO dal = new ItenaryDAO();
            int result = dal.Insert(this);
            return result;
        }

        public List<ItenaryX> GetAllItems()
        {
            ItenaryDAO dal = new ItenaryDAO();
            return dal.SelectAll();
        }
        public ItenaryX GetEmployeeById(string time)
        {
            ItenaryDAO dal = new ItenaryDAO();
            return dal.SelectById(time);
        }
        public int UpdateItenary()
        {
            ItenaryDAO dal = new ItenaryDAO();
            int result = dal.Update(this);
            return result;
        }

    }
}