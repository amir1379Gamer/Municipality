using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saskatoon.ViewModels
{
    public class DocVm
    {
        public string hourOfDay { get; set; }
        public string deviceParsedModel { get; set; }
        public string dayOfWeek { get; set; }
        public string deviceManufacturer { get; set; }
        public string deviceOS { get; set; }
        public string ownerType { get; set; }
        public string zipCode { get; set; }
        public double fees { get; set; }
        public string cardName { get; set; }
        public string authorizationCode { get; set; }
        public string purchaseId { get; set; }
        public string processingPsp { get; set; }
        public string channel { get; set; }
        public string ownerId { get; set; }
        public string deviceId { get; set; }
        public string productName { get; set; }
        public string platform { get; set; }
        public string tableName { get; set; }
        public string panFirstSix { get; set; }
        public string ingestUid { get; set; }
        public int cardIndexInTransaction { get; set; }
        public string appId { get; set; }
        public int cardsInTransaction { get; set; }
        public string productRefs { get; set; }
        public string tariffId { get; set; }
        public string brand { get; set; }
        public string merchantReference { get; set; }
        public string email { get; set; }
        public string transitDateLocal { get; set; }
        public string riderType { get; set; }
        public double totalValue { get; set; }
        public string eventId { get; set; }
        public string productFareType { get; set; }
        public string pspTransactionReference { get; set; }
        public object serverTimestamp { get; set; }
        public List<string> ipAddress { get; set; }
        public string cardType { get; set; }
        public int nbTickets { get; set; }
        public string versionNumber { get; set; }
        public string panLastFour { get; set; }
        public string deviceModel { get; set; }
        public string cardSignature { get; set; }
        public string fundingSource { get; set; }
        public string currencyCode { get; set; }
        public int nbProducts { get; set; }
        public string errorCode { get; set; }
        public string accountId { get; set; }
    }
}