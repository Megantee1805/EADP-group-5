using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.DAL; 

namespace Touristation.BLL
{
    public partial class Competiton
    {
        CompetitionDAO ComAdapter = new CompetitionDAO();

        public void addCompetition(Competiton com)
        {
            CompetitionDAO competition = new CompetitionDAO();
            competition.Insert(com);
        }

        public List<Competiton> SelectAvailableCompetitions()
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectByDate(); 
        }
       
    }
} 