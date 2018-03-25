using System;

namespace BasicIntroLinq.Models.ViewModels
{
    public class CustomerAndOrderViewModel
    {
        public int OrderID { get; set; }
        public decimal Total { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
    }


}