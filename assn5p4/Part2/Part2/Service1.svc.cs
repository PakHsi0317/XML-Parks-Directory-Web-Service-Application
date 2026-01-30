using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;

namespace Part2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string AddPark(Park park)
        {
            XDocument doc = XDocument.Load("http://www.public.asu.edu/~bjiao1/park.xml");

            XElement newPark = new XElement("Park",
                new XAttribute("type", park.Type),
                new XElement("Owner", park.Owner),
                new XElement("Name", park.Name),
                new XElement("Reservation",
                    new XElement("Address", park.Reservation.Address),
                    new XElement("Url", park.Reservation.Url)
                ),
                new XElement("NeighboringStates",
                    park.NeighboringStates.Select(state => new XElement("State", state))
                ),
                new XElement("Establishedn",
                    new XAttribute("Founder", park.Founder),
                    new XElement("Date", park.Established)
                )
            );

            doc.Element("Parks").Add(newPark);
            doc.Save("http://www.public.asu.edu/~bjiao1/park.xml");

            return "Park added successfully";
        }
        public string verification(string xml, string xmls)
        {
            string result = "No Error";
            try
            {

                XmlReaderSettings settings = new XmlReaderSettings();

                settings.Schemas.Add(null, xmls);
                settings.ValidationType = ValidationType.Schema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.IgnoreWhitespace = true;

                XmlReader restaurent = XmlReader.Create(xml, settings);
                XmlDocument document = new XmlDocument();
                document.Load(restaurent);

                ValidationEventHandler eventHandler = new ValidationEventHandler(validation);

                document.Validate(eventHandler);
               
                
            }
            catch (Exception error)
            {
                return error.Message;
            }
            return result;
        }
        void validation(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
                Console.WriteLine(" Warning" + e.Message);
            else // Error
                Console.WriteLine(" Error message" + e.Message);
        }
        public string xpathSearch(string xml, string path)
        {
            int idx = path.LastIndexOf('/');
            string select;
            string pathValue = "";
            if (idx != -1)
            {
                select = path.Substring(idx + 1);
            }
            else
            {
                select = "Name";
            }
            try
            {
                XPathDocument dx = new XPathDocument(xml);
                XPathNavigator nav = dx.CreateNavigator();
                XPathNodeIterator iterator = nav.Select(path.Substring(0, idx));

                while (iterator.MoveNext())
                {
                    XPathNodeIterator it = iterator.Current.Select(select);
                    it.MoveNext();
                    string data = it.Current.Value;
                    pathValue = pathValue + data + ", ";
                }
                return pathValue.Substring(0, pathValue.Length - 2);
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
    }
}
