using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wiki.Models
{
    public class Entry
    {   

        public int EntryID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}