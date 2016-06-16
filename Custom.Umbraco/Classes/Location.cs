namespace Custom.Umbraco.Classes
{
    using Custom.Umbraco.Helpers;

    /// <summary>
    /// 
    /// </summary>
    public class Location
    {
        public string Name { get; set; }

        public string Postcode { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public string PhoneNumber { get; set; }
        
        public static Location GetDefault()
        {
            return new Location()
            {
                Name = LocationDefaults.Name,
                Postcode = LocationDefaults.Postcode,
                PhoneNumber = LocationDefaults.PhoneNumber,
                Longitude = LocationDefaults.Longitude,
                Latitude = LocationDefaults.Latitude
            };            
        }
    }
}
