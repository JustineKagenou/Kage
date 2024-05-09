namespace CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Installment Calculator Gadget");

            Console.WriteLine("Press 1 if you are ready to use Installment Calculator.");
            int action = Convert.ToInt32(Console.ReadLine());

            while (action.Equals(1))
            {
                Console.WriteLine("1.About Installment Calculator.");
                Console.WriteLine("2.How Installment Calculator will help you.");
                Console.WriteLine("3.List of Gadgets.");
                Console.WriteLine();
                Console.WriteLine("Enter your choice.");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice.Equals(1))
                {
                    Console.WriteLine("The Installment Calculator Gadget is a tool " +
                        "that helps customers and vendors to analyze the outcome of installment payments");
                    Console.WriteLine();
                }

                if (choice.Equals(2))
                {
                    Console.WriteLine("Installment Calculator help the customers to understand the terms of installment and payments." +
                    " Allow customers to compare the different installment plans." +
                    " Allows customers to compare different installment plans." +
                    " Help vendors track Installement payments." +
                    " Calculate the total amount of money vendors will recieved.");
                    Console.WriteLine();
                }

                if (choice.Equals(3))
                {
                    Console.WriteLine("1.  APPLE iPHONE 15 Pro max");
                    Console.WriteLine("2.  APPLE iPHONE 15 Pro ");
                    Console.WriteLine("3.  APPLE iPHONE 14 Pro max");
                    Console.WriteLine("4.  APPLE iPHONE 14 Pro ");
                    Console.WriteLine("5.  APPLE iPHONE 13 Pro max");
                    Console.WriteLine("6.  APPLE iPHONE 13 Pro ");
                    Console.WriteLine("7.  APPLE iPHONE 13");
                    Console.WriteLine("8.  APPLE iPHONE 12");
                    Console.WriteLine("9.  APPLE iPHONE 11 Pro");
                    Console.WriteLine("10. APPLE iPHONE 11");
                    Console.WriteLine();
                    Console.WriteLine("What items would you like to buy?");
                    Console.WriteLine();
                    int items = Convert.ToInt32(Console.ReadLine());

                    switch (items)
                    {
                        case 1:
                            Console.WriteLine("Apple iPhone 15 Pro Max");
                            Console.WriteLine();
                            Console.WriteLine("Price: 84,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 16,998 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:67,992)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            Console.WriteLine();
                            int month1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month1.Equals(6))
                            {
                                double num1 = 84990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }

                            if (month1.Equals(9))
                            {
                                double num1 = 84990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month1.Equals(12))
                            {
                                double num1 = 84990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy1.Equals(2))
                            {
                                return;
                            }
                            break;


                        case 2:
                            Console.WriteLine("Apple iPhone 15 Pro");
                            Console.WriteLine();
                            Console.WriteLine("Price: 70,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 14,198 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:56,792)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            int month2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month2.Equals(6))
                            {
                                double num1 = 70990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month2.Equals(9))
                            {
                                double num1 = 70990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month2.Equals(12))
                            {
                                double num1 = 70990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy2.Equals(2))
                            {
                                return;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Apple iPhone 14 Pro Max");
                            Console.WriteLine();
                            Console.WriteLine("Price: 73,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 14,798 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:59,192)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            int month3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month3.Equals(6))
                            {
                                double num1 = 73990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month3.Equals(9))
                            {
                                double num1 = 73990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month3.Equals(12))
                            {
                                double num1 = 73990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy3.Equals(2))
                            {
                                return;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Apple iPhone 14 Pro");
                            Console.WriteLine();
                            Console.WriteLine("Price: 66,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 13,398 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:53,592)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            int month4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month4.Equals(6))
                            {
                                double num1 = 66990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month4.Equals(9))
                            {
                                double num1 = 66990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month4.Equals(12))
                            {
                                double num1 = 66990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy4.Equals(2))
                            {
                                return;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Apple iPhone 13 Pro Max");
                            Console.WriteLine();
                            Console.WriteLine("Price: 64,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 12,998 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:51,992)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            Console.WriteLine();
                            int month5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month5.Equals(6))
                            {
                                double num1 = 64990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month5.Equals(9))
                            {
                                double num1 = 64990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month5.Equals(12))
                            {
                                double num1 = 64990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy5.Equals(2))
                            {
                                return;
                            }
                            break;
                        case 6:
                            Console.WriteLine("Apple iPhone 13 Pro");
                            Console.WriteLine();
                            Console.WriteLine("Price: 63,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 12,998 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:51,192)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            Console.WriteLine();
                            int month6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month6.Equals(6))
                            {
                                double num1 = 63990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month6.Equals(9))
                            {
                                double num1 = 63990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month6.Equals(12))
                            {
                                double num1 = 63990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy6.Equals(2))
                            {
                                return;
                            }
                            break;
                        case 7:
                            Console.WriteLine("Apple iPhone 13");
                            Console.WriteLine();
                            Console.WriteLine("Price: 47,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 9,998 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:37,892)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            Console.WriteLine();
                            int month7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month7.Equals(6))
                            {
                                double num1 = 47990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month7.Equals(9))
                            {
                                double num1 = 47990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month7.Equals(12))
                            {
                                double num1 = 47990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy7.Equals(2))
                            {
                                return;
                            }
                            break;                      
                        case 8:
                            Console.WriteLine("Apple iPhone 12");
                            Console.WriteLine();
                            Console.WriteLine("Price: 39,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 7,998 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:31,992)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            Console.WriteLine();
                            int month8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month8.Equals(6))
                            {
                                double num1 = 39990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month8.Equals(9))
                            {
                                double num1 = 39990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month8.Equals(12))
                            {
                                double num1 = 39990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy8.Equals(2))
                            {
                                return;
                            }
                            break;
                        case 9:
                            Console.WriteLine("Apple iPhone 11 Pro");
                            Console.WriteLine();
                            Console.WriteLine("Price: 67,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 13,598 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:54,392)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            Console.WriteLine();
                            int month9 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month9.Equals(6))
                            {
                                double num1 = 67990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month9.Equals(9))
                            {
                                double num1 = 67990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month9.Equals(12))
                            {
                                double num1 = 67990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();

                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy9 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy9.Equals(2))
                            {
                                return;
                            }
                            break;
                        case 10:
                            Console.WriteLine("Apple iPhone 11");
                            Console.WriteLine();
                            Console.WriteLine("Price: 24,990");
                            Console.WriteLine();
                            Console.WriteLine("Downpayment: 4,998 (20% of the srp)");
                            Console.WriteLine();
                            Console.WriteLine("Balance:19,992)");
                            Console.WriteLine();
                            Console.WriteLine("Your payment per month will determine on how long would you like us to pay.");
                            Console.WriteLine();
                            Console.WriteLine("Choose how long would you like to pay the Gadget.");
                            Console.WriteLine();
                            Console.WriteLine("6 months, 9 months, 12months,");
                            Console.WriteLine();
                            int month10 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (month10.Equals(6))
                            {
                                double num1 = 24990;
                                double num2 = 0.05;
                                double result = ((num1 * num2) + num1) / 6;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 5% interest");
                                Console.WriteLine();
                            }
                            if (month10.Equals(9))
                            {
                                double num1 = 24990;
                                double num2 = 0.1;
                                double result = ((num1 * num2) + num1) / 9;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 10% interest");
                                Console.WriteLine();
                            }
                            if (month10.Equals(12))
                            {
                                double num1 = 24990;
                                double num2 = 0.15;
                                double result = ((num1 * num2) + num1) / 12;
                                Console.WriteLine();
                                Console.WriteLine("Monthly Payment:" + result + " because of the 15% interest");
                                Console.WriteLine();
                            }

                            Console.WriteLine("If you didn't pay on time the penalty per day is 200php.");
                            Console.WriteLine();
                            Console.WriteLine("Would you like to buy again? 1.Yes or 2.No");
                            int buy10 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (buy10.Equals(2))
                            {
                                return;
                            }           
                            break;
                        default:
                            Console.WriteLine("Invalid. Again.");
                            break;


                    }


                }

            }
        }
    }
}