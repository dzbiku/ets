using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETS.Model
{
    public class OrmDateHelpers
    {
        public string DateTimeInNet { get; set; }
        public string DateTimeInOrm { get; set; }
        private static readonly Dictionary<string, string> DateDictionary = new Dictionary<string, string>()
        {
            { "dd-MM-yyyy HH:mm:ss", "dd-mm-yyyy hh24:mi:ss"},
            { "dd-MM-yyyy", "dd-mm-yyyy"},
            { "","NoneFormating"}
        };
        public OrmDateHelpers(string dateFormatNet)
        {
            DateTimeInNet = dateFormatNet;
            DateTimeInOrm = DateDictionary.FirstOrDefault(s => s.Key == dateFormatNet).Value;
        }
    }
}
