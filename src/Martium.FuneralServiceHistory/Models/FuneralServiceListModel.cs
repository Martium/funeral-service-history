using System;

namespace Martium.FuneralServiceHistory.Models
{
    public class FuneralServiceListModel
    {
        public int OrderNumber { get; set; }
        public string ServiceDates { get; set; }
        public string CustomerNames { get; set; }
        public string CustomerPhoneNumbers { get; set; }
        public string DepartedInfo { get; set; }
    }
}