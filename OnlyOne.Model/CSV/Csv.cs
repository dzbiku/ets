using System.Collections.Generic;
using System.Data;

namespace OnlyOne.Model.CSV
{
    public class Csv
    {
        public string[] Header { get; set; }
        public List<string[]> Content { get; set; }
        

        #region convert to other types of data

        /// <summary>
        /// Converrt to DataTable object from model
        /// </summary>
        /// <returns></returns>
        public DataTable ToDataTable()
        {
            DataTable dtResult = new DataTable();
            foreach (string headerCell in Header)
            {
                dtResult.Columns.Add(headerCell);
            }
            foreach (var contentRow in Content)
            {
                DataRow dr = dtResult.NewRow();
                for (int i = 0; i < Header.Length; i++)
                {
                    dr[i] = contentRow[i];
                }
                dtResult.Rows.Add(dr);
            }
            return dtResult;
        }

        #endregion
    }
}
