﻿using System;
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
    }
}