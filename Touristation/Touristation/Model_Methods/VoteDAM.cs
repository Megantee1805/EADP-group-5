using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.DAL;

namespace Touristation.BLL
{
    public partial class Vote
    {
        public void CastVotes(Vote count)
        {
            VoteDAO voting = new VoteDAO();
            voting.Insert(count); 
        }

        public Vote checkPreviousVotes(int userId, int entryId)
        {
            Vote previous; 
            VoteDAO vote = new VoteDAO();
            previous = vote.SelectByUserandEntry(userId, entryId);
            return previous; 

        }

        public void RemoveVotes(int id)
        {
            VoteDAO voting = new VoteDAO();
            voting.Delete(id); 
        }
    }
}