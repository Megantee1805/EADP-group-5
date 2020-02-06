using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.DAL;

namespace Touristation.BLL
{
    public partial class Entry
    {
        EntryDAO adapter = new EntryDAO();

        public void AddEntry(Entry ent)
        {
            EntryDAO insert = new EntryDAO();
            insert.Insert(ent);
        }

        public List<Entry> GetAll()
        {
            EntryDAO all = new EntryDAO();
            return all.SelectAll();
        }

        public Entry GetEntryById(int Id)
        {
            EntryDAO all = new EntryDAO();
            return all.SelectById(Id);
        }

        public List<Entry> GetEntriesByCompetition(int ComId)
        {
            EntryDAO all = new EntryDAO();
            return all.SelectByCompetition(ComId);
        }

        public List<Entry> GetAllEntriesByOthers(int ComId, int userId)
        {
            EntryDAO all = new EntryDAO();
            return all.SelectByComandUser(ComId, userId);
        }

        public List<Entry> GetEntriesByUser(int userId)
        {
            EntryDAO all = new EntryDAO();
            return all.SelectByUser(userId);
        }

        public void CountVotes(Entry ent)
        {
            EntryDAO entry = new EntryDAO();
            entry.Update(ent);
        }

        public void tallyVotes(int Id)
        {
            List<Entry> total;
            EntryDAO entry = new EntryDAO();
            total = entry.SelectByCompetition(Id);
            total = total.OrderByDescending(e => e.votes).ToList(); 
            int ranking = 1;
            
            foreach (Entry e in total)
            {
                e.rank = ranking;
                ranking += 1;
                entry.Update(e); 
            }

            
            
        }

        public void rankScore(int id)
        {
            List<Entry> total;
            EntryDAO entry = new EntryDAO();
            total = entry.SelectByCompetition(id);
            total = total.OrderByDescending(e => e.score).ToList();
            int ranking = 1;

            foreach (Entry e in total)
            {
                e.rank = ranking;
                ranking += 1;
                entry.Update(e);
            }

        }


        public void Update(Entry ent)
        {
            EntryDAO entry = new EntryDAO();
            entry.Update(ent); 
        }

        public void Delete(int id)
        {
            EntryDAO entry = new EntryDAO();
            entry.Delete(id);
        }
    }
}