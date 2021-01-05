using System;

namespace Martium.FuneralServiceHistory.Models
{
    public class FuneralServiceModel
    {
        public int OrderCreationYear => DateTime.Now.Year;
        public DateTime OrderDate { get; set; }
        public string CustomerNames { get; set; }
        public string CustomerPhoneNumbers { get; set; }
        public string CustomerEmails { get; set; }
        public string CustomerAddresses { get; set; }
        public string ServiceDates { get; set; }
        public string ServicePlaces { get; set; }
        public string ServiceTypes { get; set; }
        public string ServiceDuration { get; set; }
        public string ServiceMusiciansCount { get; set; }
        public string ServiceMusicProgram { get; set; }
        public string DepartedInfo { get; set; }
        public string DepartedConfession { get; set; }
        public string DepartedRemainsType { get; set; }
        public string ServiceMusicianUnitPrices { get; set; }
        public string ServiceDiscountPercentage { get; set; }
        public string ServicePaymentAmount { get; set; }
        public string ServicePaymentType { get; set; }
        public string ServiceDescription { get; set; }
    }
}