using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ETS.Model.CSV
{
    public class Csv
    {
        public string[] Header { get; set; }
        public List<string[]> Content { get; set; }

        public DataTable ToDataTable()
        {
            DataTable dtResult = new DataTable();
            foreach (string headerCell in Header)
            {
                dtResult.Columns.Add(headerCell);
            }

            
            for (int j = 0; j < Content.Count; j++)
            {
                DataRow dr = dtResult.NewRow();
                for (int i = 0; i < Header.Length; i++)
                {
                    dr[i] = Content[j][i];
                }
                dtResult.Rows.Add(dr);
            }

            return dtResult;
        }
    }
}
