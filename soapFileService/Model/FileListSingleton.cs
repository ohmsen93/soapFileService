using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace soapFileService
{
    [DataContract]
    public class FileListSingleton
    {
        [DataMember]
        public static List<string> FileList { get; set; } 
    }
}