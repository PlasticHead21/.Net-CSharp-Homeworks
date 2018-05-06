using System;

namespace LinqQuery
{
    [Serializable]
    public class CD
    {
        public string TITLE { get; set; }
        public string ARTIST { get; set; }
        public string COUNTRY { get; set; }
        public string COMPANY { get; set; }
        public decimal PRICE { get; set; }
        public int YEAR { get; set; }
        public string PRODUCER { get; set; }
    }
}