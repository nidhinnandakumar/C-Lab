namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> exchangeRates = new Dictionary<string, double>
        {
            {"USD", 1.0},
            {"EUR", 0.85},
            {"INR", 0.75},
            {"SGP", 0.40},


            // Add more currencies and their exchange rates as needed
        };

            // Get user input: amount and source currency
            Console.Write("Enter the amount: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.Write("Enter the source currency (e.g., USD): ");
                string sourceCurrency = Console.ReadLine().ToUpper();
                

                // Get user input: target currency
                Console.Write("Enter the target currency (e.g., EUR): ");
                string targetCurrency = Console.ReadLine().ToUpper();

                // Call the conversion function
                double convertedAmount = ConvertCurrency(amount, sourceCurrency, targetCurrency, exchangeRates);

                // Display the result
                Console.WriteLine($"{amount} {sourceCurrency} is equal to {convertedAmount} {targetCurrency}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric amount.");
            }
        }

        static double ConvertCurrency(double amount, string sourceCurrency, string targetCurrency, Dictionary<string, double> exchangeRates)
        {
            // Check if the source and target currencies exist in the dictionary
            if (exchangeRates.ContainsKey(sourceCurrency) && exchangeRates.ContainsKey(targetCurrency))
            {
                // Convert to USD first
                double usdAmount = amount / exchangeRates[sourceCurrency];

                // Convert to the target currency
                double convertedAmount = usdAmount * exchangeRates[targetCurrency];

                return convertedAmount;
            }
            else
            {
                Console.WriteLine("Invalid currency codes. Please check the currency codes and try again.");
                return 0;
            }
         /*   Dictionary<string, string> currencies = new Dictionary<string, string>
            {
                {"INR","Indian Rupee"},
                {"USD","United States Dollar" },
                {"SGD","Singapore Dollar"},
                {"EUR","Euro" }

            };
            foreach(var currency in currencies)
            {
                Console.WriteLine(currency.);
            }

            Dictionary<string,KeyValuePair<string,double>>currency = new Dictionary<string, KeyValuePair<string, double>>
            {
                {"INR",new KeyValuePair<string,double>("USD",0.17) },
                {"USD",new KeyValuePair<string,double>("USD", 83) },
                {"INR",new KeyValuePair<string,double>("SGD",0.24) },

            };*/

         



        }
    }
}