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
                var queryString = "http://dev.virtualearth.net/REST/v1/Locations/" + latitude.ToString() + "," + longitude.ToString() + "?key=aE6WcyZB1k73jIDR0JSs~WEFGdo28qs9ewZgD2_wqhQ~AuejjdIfnOgOaWrUQfCHVcwQYKGN0Py3IGCFNhL9caszY_FleTgt0BYYv6aO-c6X";

                string response = client.DownloadString(queryString);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Response));
                using (var es = new MemoryStream(Encoding.Unicode.GetBytes(response)))
                {
                    var mapResponse = (ser.ReadObject(es) as Response);
                    var location = (BingMapsRESTToolkit.Location)mapResponse.ResourceSets.First().Resources.First();
                    return new AddressResult()
                    {
                        AddressLine = location.Address.AddressLine,
                        Locality = location.Address.Locality,
                    };
                }
            }
        }
    }
}
