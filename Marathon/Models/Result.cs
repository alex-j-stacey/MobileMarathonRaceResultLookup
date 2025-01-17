﻿using System;
namespace Marathon.Models
{
    public class ResultsCollection
    {
       public Result[] results { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public int race_id { get; set; }
        public string placement { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public string state { get; set; }

        public string detail { get {
                return placement + " Place   |   Time: " + time + "   |   State: " + state; } }
    }
}
