namespace ElectricityBillingAutomation.Models
{
    public class ElectricityBill
    {
        public string ConsumerNumber { get; set; }
        public string ConsumerName { get; set; }
        public int UnitsConsumed { get; set; }
        public double BillAmount { get; set; }
    }
}
