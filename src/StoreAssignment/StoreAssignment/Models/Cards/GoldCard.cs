namespace StoreAssignment.Models.Cards
{
    public class GoldCard : Card
    {
        private const double INITIAL_DISCOUNT_RATE = 0.02d;
        private const double DISCOUNT_RATE_MULTYPLIER = 0.01;
        private const double MAX_DISCOUNT_RATE = 0.1d;

        private double discountRate;
        private double discount;
        private double total;

        public GoldCard(string name, double turnoverForThePreviousMonth, double purchaseValue)
            :base(name, turnoverForThePreviousMonth,purchaseValue)
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
                this.discountRate = INITIAL_DISCOUNT_RATE;
                int multyplier = (int)TurnoverForThePreviousMonth / 100;

                for (int i = 0; i < multyplier; i++)
                {
                    discountRate += DISCOUNT_RATE_MULTYPLIER;
                }

                if (discountRate>MAX_DISCOUNT_RATE)
                {
                    discountRate = MAX_DISCOUNT_RATE;
                }
            }
        }
    }
}
