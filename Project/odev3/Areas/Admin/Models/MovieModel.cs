using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odev3.Areas.Admin.Models
{
    public class MovieModel
    {
        public string MovieName { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public string MovieGenre { get; set; }
        public HttpPostedFileBase MoviePoster { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Trailer { get; set; }
        public string Country { get; set; }
        public Nullable<double> Rating { get; set; }
    }
    public class TaskModel
    {
        public HttpPostedFileBase Task_Avatar { get; set; }
        public int Task_Date_Day { get; set; }
        public string Task_Date_Month { get; set; }
        public string Task_Header { get; set; }
        public string Full_Task { get; set; }
    }
}