using System;

namespace AJW.Models
{
     public class Order {
         
         public int SaleOrderDetailAutoKey { get; set; }
         public int CompanyAutoKey { get; set; }
         public string CompanyRefNumber { get; set; }
         public string SoNumber { get; set; }
         public DateTimeOffset? DateCreated { get; set; }
         public string ShipAddress1 { get; set; }
         public string ShipAddress2 { get; set; }
         public string Attention { get; set; }
         public char OpenFlag { get; set; }
         public int NumberOfItems { get; set; }
         public int ItemNumber { get; set;}
         public char RouteCode { get; set; }
         public string PnUpper { get; set; }
         public int QtyOrdered { get; set; }
         public int QtyReserved { get; set; }
         public int QtyPendingInvoice { get; set; }
         public int QtyInvoiced { get; set;}
         public string DescriptionUpper { get; set; }
         public int? CustomerPrice{get; set;}
         public string CurrencyCode { get; set; }
         public DateTimeOffset? NextShipDate { get; set; }
         public int PartsMasterAutoKey { get; set; }
         public string CompanyName { get; set; }

     }
    

}