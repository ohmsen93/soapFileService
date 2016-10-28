using System.Net;
using System.Runtime.Serialization;

namespace soapFileService
{
    [DataContract]
    public class File
    {
        private string _fileName;
        private IPAddress _ip;
        private int _port;
        
        [DataMember]
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        [DataMember]
        public IPAddress Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        [DataMember]
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public override string ToString()
        {
            return $"FileName: {FileName}, Ip: {Ip}, Port: {Port}";
        }
    }
}