namespace StoreAssignment.Factories
{
    using System.Collections.Generic;

    using StoreAssignment.Models;
    using StoreAssignment.Models.Cards;
    
    public class CardFactory
    {
        public Card Create(List<string> cardInfoArgs)
        {
            Card card = null;

            string type = cardInfoArgs[0];
            string name = cardInfoArgs[1];
            double previousMonthTurnover = double.Parse(cardInfoArgs[2]);
            double purchaseValue = double.Parse(cardInfoArgs[3]);

            switch (type)
            {
                case "Bronze":
                    card = new BronzeCard(name, previousMonthTurnover, purchaseValue);
                    break;
                case "Silver":
                    card = new SilverCard(name, previousMonthTurnover, purchaseValue);
                    break;
                case "Gold":
                    card = new GoldCard(name, previousMonthTurnover, purchaseValue);
                    break;
            }
            return card;
        }
    }
}
