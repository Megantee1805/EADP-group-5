using Touristation.BLL;
using Touristation.DAL; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Touristation.Model_Methods
{
    public partial class Itnerary
    {

        public List<Itnerary> GetAllItems()
        {
            ItneraryDAO dal = new ItenaryDAO();
            return dal.SelectAll();
        }
        public ItenaryX GetEmployeeById(string time)
        {
            ItenaryDAO dal = new ItenaryDAO();
            return dal.SelectById(time);
        }

        public int AddItenary(ItenaryX itn)
        {
            ItenaryDAO dal = new ItenaryDAO();
            int result = dal.Insert(itn);
            return result;
        } 
        public int UpdateItenary(ItenaryX itn)
        {
            ItenaryDAO dal = new ItenaryDAO();
            int result = dal.Update(itn);
            return result;

        }
    }
}