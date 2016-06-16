using Custom.Umbraco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Custom.Umbraco.Helpers
{
    static class LocationDefaults
    {
        public static string Name
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultLocationName"];
            }
        }

        public static string Postcode
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultLocationPostcode"];
            }
        }

        public static string PhoneNumber
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultLocationPhoneNumber"];
            }
        }

        public static string Latitude
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultLocationLatitude"];
            }
        }

        public static string Longitude
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultLocationLongitude"];
            }            
        }
    }
}
