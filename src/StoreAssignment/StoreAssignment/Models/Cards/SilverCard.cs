namespace StoreAssignment.Models.Cards
{
    public class SilverCard : Card
    {
        private const double INITIAL_DISCOUNT_RATE = 0.02d;
        private const double MAX_DISCOUNT_RATE = 0.035;

        private double discountRate;
        private double discount;
        private double total;

        public SilverCard(string name, double turnoverForThePreviousMonth, double purchaseValue)
            : base(name, turnoverForThePreviousMonth, purchaseValue)
        {
            this.DiscountRate = discountRate;
            this.Discount = discount;
            this.Total = total;
        }

        public override double DiscountRate 
        {
            get
            {
                return this.discountRate;
            }
            set
            {
                if (TurnoverForThePreviousMonth>300)
                {
                    this.discountRate = MAX_DISCOUNT_RATE;
                }
                else
                {
                    this.discountRate = INITIAL_DISCOUNT_RATE;
                }
            }
        }
    }
}
