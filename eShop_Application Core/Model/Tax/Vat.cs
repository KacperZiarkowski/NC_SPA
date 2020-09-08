namespace eShop_ApplicationCore.Model.Tax
{
    public class Vat : Entity
    {
        public decimal VatRate { get; set; }


        public VatRule VatRule { get; set; }


        public int VatRuleId { get; set; }

    }
}
