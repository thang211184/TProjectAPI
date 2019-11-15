using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TProjectAPI.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public String Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int EmployeeID { get; set; }
    }
}