namespace StoreAssignment.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Engine
    {
        

        public static void Run()
        {
            var payDesk = new PayDesk();

            bool isNotFinished = true;

            while (isNotFinished)
            {

                string result = string.Empty;
                string input = Console.ReadLine();

                List<string> cardInfoArgs = input.Split().ToList();

                string command = cardInfoArgs[0];
                cardInfoArgs = cardInfoArgs.Skip(1).ToList();

                switch (command)
                {
                    case "Create": payDesk.Create(cardInfoArgs); break;
                    case "Checkout":payDesk.Check(cardInfoArgs); break;
                }
                if (result != string.Empty)
                {
                    Console.WriteLine(result);
                    isNotFinished = false;
                }
            }
        }
    }
}
