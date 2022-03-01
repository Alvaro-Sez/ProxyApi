using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Ejercicio7.Dtos
{
    public class Result
    {
        public int id { get; set; }
        public string text { get; set; }
        public string entry_requirements { get; set; }
        public string origin_text { get; set; }
        public int region_id { get; set; }
        public string region_name { get; set; }
        public string last_update { get; set; }
        public string last_review { get; set; }
        public List<Extra> extra { get; set; }
        public List<ExtraVaccine> extra_vaccine { get; set; }
        public object country_id { get; set; }
        public object country_name { get; set; }
        public object parent_id { get; set; }
        public object parent_name { get; set; }
        public AddOns add_ons { get; set; }
        public int openness_status { get; set; }
        public int openness_status_vaccine { get; set; }
        public int level { get; set; }
        public object flag { get; set; }
        public bool childs { get; set; }
        public string transit { get; set; }
        public string quarantine { get; set; }
        public string destination_test { get; set; }
        public string origin_test { get; set; }
        public string forms { get; set; }
        public string hub_cities { get; set; }
        public string health_information { get; set; }
        public string mask { get; set; }
        public string social_distancing { get; set; }
        public string health_insurance { get; set; }
        public string special_flights { get; set; }
        public string vaccine_text { get; set; }
        public string vaccine_requirements { get; set; }
    }
}
