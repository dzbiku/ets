using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ETS.Model
{
    public class OrmObject
    {
        public OrmDateHelpers OrmDate { get; set; }
        public OperationTypes OptType { get; set; }
        public DataTable ResultsDataTable { get; set; }
        public string FinalTableName { get; set; }

        public enum OperationTypes
        {
            Select,
            Insert,
            Update,
            Delete
        };

        public OrmObject(string date, string finTableName, DataTable dtRes, OperationTypes optType = OperationTypes.Insert)
        {
            OrmDate = new OrmDateHelpers(date);
            OptType = optType;
            ResultsDataTable = dtRes;
            FinalTableName = finTableName;
        }
    }
}
