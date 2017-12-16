using BingMapsRESTToolkit;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class GeocodeHelper
    {
        public AddressResult ReverseGeocode(double latitude, double longitude)
        {
            using (var client = new WebClient())
            {
                string lat = latitude.ToString();
                string lon = longitude.ToString();

                if (!lat.Contains("."))
                {
                    var latstr = latitude.ToString().Split(new char[] { ',' });
                    lat = latstr[0] + "." + latstr[1];

                    var longstr = longitude.ToString().Split(new char[] { ',' });
                    lon = longstr[0] + "." + longstr[1];
                }

                var queryString = "http://dev.virtualearth.net/REST/v1/Locations/" + lat + "," + lon + "?key=aE6WcyZB1k73jIDR0JSs~WEFGdo28qs9ewZgD2_wqhQ~AuejjdIfnOgOaWrUQfCHVcwQYKGN0Py3IGCFNhL9caszY_FleTgt0BYYv6aO-c6X";

                string response = client.DownloadString(queryString);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Response));
                using (var es = new MemoryStream(Encoding.Unicode.GetBytes(response)))
                {
                    var mapResponse = (ser.ReadObject(es) as Response);
                    try
                    {
                        var location = (BingMapsRESTToolkit.Location)mapResponse.ResourceSets.First().Resources.First();
                        return new AddressResult()
                        {
                            AddressLine = location.Address.AddressLine,
                            Locality = location.Address.Locality,
                        };
                    }
                    catch
                    {
                        return new AddressResult();
                    }
                }
            }
        }

        public AddressResult GetAddress(string location)
        {
            GeocodeHelper gh = new GeocodeHelper();
            string[] array = location.Split(new Char[] { ',' });
            double x, y;

            if (location.Contains("."))
            {               
                x = Convert.ToDouble(array[0]);
                y = Convert.ToDouble(array[1]);
            }
            else
            {
                x = Convert.ToDouble(array[0] + "," + array[1]);
                y = Convert.ToDouble(array[2] + "," + array[3]);
            }

            return gh.ReverseGeocode(x, y);
        }
    }
}
