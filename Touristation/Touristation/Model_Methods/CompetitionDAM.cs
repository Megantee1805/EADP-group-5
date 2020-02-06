using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.DAL; 

namespace Touristation.BLL
{
    public partial class Competition
    {
        CompetitionDAO ComAdapter = new CompetitionDAO();

        public void addCompetition(Competition com)
        {
            CompetitionDAO competition = new CompetitionDAO();
            competition.Insert(com);
        }

        public void countEntries(Competition comie)
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

        public List<Competition> SelectAll()
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectAll();
        }

        public List<Competition> SelectAvailableCompetitions(string userId)
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectByDate(userId); 
        }

        public List<Competition> SelectJudgingCompetitions(string userId)
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectByJudge(userId);
        }

        public List<Competition> SelectEndedCompetitions()
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectFinishedCom();
        }

        public Competition GetCompetitionByName(string name)
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectByTitle(name);
        }

        public Competition GetCompetitionById(int Id)
        {
            CompetitionDAO com = new CompetitionDAO();
            return com.SelectById(Id);
        }

        public void SelectWinner(int Id)
        {
            CompetitionDAO com = new CompetitionDAO(); 
            List<Entry> total;
            Competition ended; 
            EntryDAO entry = new EntryDAO();
            total = entry.SelectByCompetition(Id);
            total = total.OrderBy(e => e.rank).ToList();
            ended = com.SelectById(Id);
            ended.winners = total[0].Id.ToString();
            com.Update(ended); 
        }

        public void Update(Competition comie)
        {
            CompetitionDAO com = new CompetitionDAO();
            com.Update(comie);
        }

        public void Delete(int id)
        {
            CompetitionDAO user = new CompetitionDAO();
            user.Delete(id);
        }

    }
} 