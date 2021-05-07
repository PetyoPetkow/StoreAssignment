namespace StoreAssignment
{
    using StoreAssignment.Factories;
    using StoreAssignment.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PayDesk
    {
        private List<Card> cards;
        private CardFactory cardFactory;

        public PayDesk()
        {
            this.cards = new List<Card>();
            this.cardFactory = new CardFactory();
        }

        public void Create(List<string> CardInfoArgs)
        {
            Card card = cardFactory.Create(CardInfoArgs);
            cards.Add(card);
        }

        public void Check(List<string> args)
        {
            Card card = cards.Where(c => c.Name == args[0]).FirstOrDefault();
            Checkout(card);
        }

        public static void Checkout(Card card)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Console.WriteLine();
            stringBuilder.AppendLine($"Owner name: {card.Name}");
            stringBuilder.AppendLine($"Purchase Value: ${card.PurchaseValue:F}");
            stringBuilder.AppendLine($"Discount rate: {card.DiscountRate*100:F}%");
            stringBuilder.AppendLine($"Discount: ${card.Discount:F}");
            stringBuilder.AppendLine($"Total: ${card.Total:F}");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
