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

        public void RemoveVotes(int id)
        {
            VoteDAO voting = new VoteDAO();
            voting.Delete(id); 
        }
    }
}