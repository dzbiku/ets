﻿using System.Collections.Generic;
using System.IO;

namespace OnlyOne.Model.CSV
{
    public class Reader
    {
        /// <summary>
        ///  Method fro convert from csv file to datatable.
        /// </summary>
        /// <param name="fModel"></param>
        /// <param name="separator"> You must select separator: ';' or ','</param>
        /// <param name="quotation"> if in string is "field_name" set true</param>
        /// <returns></returns>
        public static Csv Read(FileModel fModel, char separator, bool quotation = false)
        {
            Csv csv = new Csv();
            using (StreamReader sr = new StreamReader(fModel.FullPathWithFileNameAndDir))
            {
                var headers = sr.ReadLine()?.Split(separator);
                if (headers != null)
                {
                    csv.Header = new string[headers.Length];
                    for (var i = 0; i < headers.Length; i++)
                    {
                        string header = headers[i];

                        csv.Header[i] = quotation ? header.Replace("\"", "") : header;
                    }
                }
                csv.Content = new List<string[]>();
                while (!sr.EndOfStream)
                {
                    string[] contentRows = sr.ReadLine()?.Split(separator);
                    if (contentRows != null)
                        for (var i = 0; i < contentRows.Length; i++)
                        {
                            contentRows[i] = quotation ? contentRows[i].Replace("\"", "") : contentRows[i];
                        }

                    csv.Content.Add(contentRows);
                }
            }

            return csv;
        }
    }
}
