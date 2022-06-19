namespace CreditCardLibrary
{
    public class CreditCard
    {
        private long _numberofcard;
        public CreditCard(long NumberOfCard)
        {
            _numberofcard = NumberOfCard;
        }
        public string GetTypeCard(long card)
        {
            string type;
            int sum1 = 0, sum2 = 0;
            if (card.ToString().StartsWith("4") && (card.ToString().Length == 13 || card.ToString().Length == 16))
                type = "VISA";
            else if (card.ToString().StartsWith("34") || card.ToString().StartsWith("37") && card.ToString().Length == 15)
                type = "AMEX";
            else if (card.ToString().StartsWith("54") || card.ToString().StartsWith("55") || card.ToString().StartsWith("53") || card.ToString().StartsWith("52") || (card.ToString().StartsWith("51") && card.ToString().Length == 16))
                type = "MASTERCARD";
            else
                type = "INVAID";
            for (int i = 0; i < card.ToString().Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (2 * int.Parse(card.ToString()[i].ToString()) < 9)
                        sum1 += 2 * int.Parse(card.ToString()[i].ToString());
                    else
                        sum1 += (2 * int.Parse(card.ToString()[i].ToString())) - 9;
                }
                else
                {
                    sum2 += int.Parse(card.ToString()[i].ToString());
                }
            }

            if ((sum1 + sum2) % 10 != 0)
                type = "INVALID";
            return type;
        }
    }
}