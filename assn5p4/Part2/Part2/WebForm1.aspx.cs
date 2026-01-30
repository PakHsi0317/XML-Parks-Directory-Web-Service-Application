using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;


namespace Part2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void verificationButton_Click(object sender, EventArgs e)
        {

           
            string xml = xmlTextBox.Text;
            string xmls = xmlsTextBox.Text;
            string url = "http://localhost:63927/Service1.svc/verification?xml="+xml+"&xmls="+xmls;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();
            string validationStr = JsonConvert.DeserializeObject<string>(responsereader);
            resultTextBox.Text = validationStr;
            
        }

        protected void xpathButton_Click(object sender, EventArgs e)
        {
           
            string xml = xml2TextBox.Text;
            string path = expressionTextBox.Text;
            string url = "http://localhost:63927/Service1.svc/xpathSearch?xml=" + xml + "&path=" + path;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();
            string pathValue = JsonConvert.DeserializeObject<string>(responsereader);
            result2TextBox.Text = pathValue;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}