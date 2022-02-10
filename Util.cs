using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Browser
{
    public class Util
    {
        static public bool IsIP(string host)
        {
            return IPAddress.TryParse(host, out _);
        }

        static public bool IsURI(string host)
        {
            try
            {
                if (Regex.IsMatch(host, "^[^ .]+$"))
                {
                    return false;
                }
                new Uri(Constants.HTTPS + host);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
