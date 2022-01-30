using System.Net;
using System.Text;

namespace Parser;

public class InfoParser : IParse
{
    public string Parse(string URL)
    {
        StringBuilder result = new StringBuilder();
        
        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Accept = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            result.Append(reader.ReadToEnd());
            response.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("The exception was thrown: " + ex.Message);
        }

        return result.ToString();
    }
}