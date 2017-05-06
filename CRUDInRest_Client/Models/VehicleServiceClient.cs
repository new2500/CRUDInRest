using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;

namespace CRUDInRest_Client.Models
{
    public class VehicleServiceClient
    {
        private string BASE_URL = "http://localhost:12557/ServiceVehicle.svc/";

        public List<Vehicle> getall()
        {
            try
            {
                var webCLient = new WebClient();
                var json = webCLient.DownloadString(BASE_URL + "getall");
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Vehicle>>(json);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Vehicle get(string id)
        {
            try
            {
                var webCLient = new WebClient();
                string url = string.Format(BASE_URL + "get/{0}", id);
                var json = webCLient.DownloadString(url);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Vehicle>(json);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool create(Vehicle vehicle)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Vehicle));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, vehicle);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(BASE_URL + "create", "POST", data);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool edit(Vehicle vehicle)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Vehicle));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, vehicle);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(BASE_URL + "edit", "PUT", data);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool delete(Vehicle vehicle)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Vehicle));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, vehicle);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(BASE_URL + "delete", "DELETE", data);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}