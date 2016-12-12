using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
    public class Library
    {
        public int ID { get; set; }
        public int TypeID { get; set; }
        public int LanguageID { get; set; }
        public int CategoryID { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }
        public String Publisher { get; set; }
        public DateTime DatePurchased { get; set; }
        public Double Price { get; set; }
        public String ISBN_ISSN { get; set; }
        public String Comment { get; set; }
    }
}