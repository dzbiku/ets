using System;
using System.IO;

namespace ETS.Model
{
    public class FileModel
    {
        public string PathToFile { get; set; }
        public string FileName { get; set; }
        public string FullPathWithFileNameAndDir { get; set; }


        public FileModel(string fullPath)
        {
            FullPathWithFileNameAndDir = fullPath;
            FileName = Path.GetFileName(FullPathWithFileNameAndDir);
            PathToFile = Path.GetDirectoryName(FullPathWithFileNameAndDir);
        }
    }
}
