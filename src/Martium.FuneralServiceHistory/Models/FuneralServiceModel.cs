using System;

namespace Martium.FuneralServiceHistory.Models
{
    public class FuneralServiceModel
    {
        public DateTime OrderDate { get; set; }
        public string CustomerNames { get; set; }
        public string CustomerPhoneNumbers { get; set; }
        public string CustomerEmails { get; set; }
        public string CustomerAddresses { get; set; }
        public string ServiceDates { get; set; }
        public string ServicePlaces { get; set; }
        public string ServiceTypes { get; set; }
        public decimal ServiceDuration { get; set; }
        public int ServiceMusiciansCount { get; set; }
        public string ServiceMusicProgram { get; set; }
        public string DepartedInfo { get; set; }
        public string DepartedRemainsType { get; set; }
        public string ServiceMusicianUnitPrices { get; set; }
        public int ServiceDiscountPercentage { get; set; }
        public decimal ServicePaymentAmount { get; set; }
        public string ServicePaymentCurrencyCode { get; set; }
        public string ServicePaymentType { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceReviewScore { get; set; }
        public string ServiceReviewComments { get; set; }
    }
}