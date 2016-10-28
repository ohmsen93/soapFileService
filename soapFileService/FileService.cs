using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace soapFileService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class FileService : IFileService
    {
        public void AddFileList(string FileName)
        {
            FileListSingleton.FileList.Add(FileName);
        }

        public string SearchFileList(string searchValue)
        {
            Console.WriteLine("Søger på: "+searchValue);
            foreach (var File in FileListSingleton.FileList)
            {
                Console.WriteLine(File);
            }
            Console.WriteLine("Søgning Færdig");
            return "SearchComplete";
        }

    }
}
