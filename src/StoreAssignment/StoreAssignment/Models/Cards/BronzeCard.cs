namespace StoreAssignment.Models.Cards
{
    public class BronzeCard : Card
    {
        private const double INITIAL_DISCOUNT_RATE = 0;
        private const double MEDIUM_DISCOUNT_RATE = 0.01;
        private const double MAX_DISCOUNT_RATE = 0.025;

        private double total;
        private double discountRate;
        private double discount;

        public BronzeCard(string name, double turnoverForThePreviousMonth, double purchaseValue)
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
                if (TurnoverForThePreviousMonth<100)
                {
                    discountRate = INITIAL_DISCOUNT_RATE;
                }
                else if (TurnoverForThePreviousMonth>100 && TurnoverForThePreviousMonth<300)
                {
                    discountRate = MEDIUM_DISCOUNT_RATE;
                }
                else
                {
                    discountRate = MAX_DISCOUNT_RATE;
                }   
            }
        }
    }
}
