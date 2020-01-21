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