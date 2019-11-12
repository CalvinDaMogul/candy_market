using System;

namespace CandyMarket.Api.DataModels
{
    public class Candy
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public int billingactive { get; set; }
        public int hasSSO { get; set; }
        public int has2fa { get; set; }
        public string userid { get; set; }
        public string fullname { get; set; }
        public string displayname { get; set; }
    }
}
