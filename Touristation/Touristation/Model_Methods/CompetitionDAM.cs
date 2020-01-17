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

        public void countEntries(Competiton comie)
        {
            int count = 0; 
            List<Entry> all; 
            CompetitionDAO com = new CompetitionDAO();
            EntryDAO ent = new EntryDAO();
            all = ent.SelectByCompetition(comie.Id); 
            
            foreach (Entry e in all)
            {
                count = count + 1; 
            }
            comie.entriesNo = count; 
            com.Update(comie); 
        }

        public List<Competiton> SelectAvailableCompetitions()
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectByDate(); 
        }

        public Competiton GetCompetitionByName(string name)
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectByTitle(name);
        }

        public Competiton GetCompetitionById(int Id)
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectById(Id);
        }

    }
} 