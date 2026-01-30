using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Part2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "verification?xml={xml}&xmls={xmls}", ResponseFormat = WebMessageFormat.Json)]
        string verification(string xml, string xmls);

        [OperationContract]
        [WebGet(UriTemplate = "xpathSearch?xml={xml}&path={path}", ResponseFormat = WebMessageFormat.Json)]
        string xpathSearch(string xml, string path);
        // TODO: Add your service operations here
        
       
            [OperationContract]
            [WebInvoke(
                Method = "POST",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json,
                UriTemplate = "AddPark"
            )]
            string AddPark(Park park);
    }
    [DataContract]
    public class Park
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Owner { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Reservation Reservation { get; set; }

        [DataMember]
        public List<string> NeighboringStates { get; set; }

        [DataMember]
        public string Established { get; set; }

        [DataMember]
        public string Founder { get; set; }
    }

    [DataContract]
    public class Reservation
    {
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Url { get; set; }
    }
}
