namespace StoreAssignment.Models
{
    public abstract class Card
    {
        private double discount;
        private double total;

        public Card(string name, double turnoverForThePreviousMonth, double purchaseValue)
        {
            Name = name;
            TurnoverForThePreviousMonth = turnoverForThePreviousMonth;
            PurchaseValue = purchaseValue;
            Total = total;
            Discount = discount;
        }

        public virtual string Name { get; set; }

        public virtual double TurnoverForThePreviousMonth { get; set; }

        public virtual double PurchaseValue { get; set; }

        public abstract double DiscountRate { get; set; }

        public virtual double Discount
        {
            get
            {
                return this.discount;
            }
            set
            {

                this.discount = PurchaseValue * DiscountRate;

            }
        }
        public virtual double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = PurchaseValue - Discount;
            }
        }

    }
}
