using Microsoft.EntityFrameworkCore;

namespace SurveyTask.Model
{
    public class SurveyData
    {
        public int Id { get; set; }
        public int tr_id { get; set; }
        public string mdo_code { get; set; }
        public string firm_name { get; set; }
        public string state { get; set; }
        public string dist { get; set; }
        public string taluka { get; set; }
        public string village { get; set; }
        public double pincode { get; set; }
        public string cordinates { get; set; }
        public string geoaddress { get; set; }
        public string category { get; set; }
        public string crop { get; set; }
        public string company { get; set; }
        public string distributor { get; set; }
        public string retailer { get; set; }
        public string no_access { get; set; }
        public DateTime uploaded_date { get; set; }
        public string season { get; set; }
        public string territory_name { get; set; }
    }
}


