using System;



namespace Task6

{
    class Program
    {
        static void Main(string[] args)
        {
            //setup

            Single orderSubTotal = 0;
            Double orderGrandTotal = 0;
            Double stateTaxTotal = 0;
            Double localTaxTotal = 0;
            string Subtot = string.Empty;
            string TryAgain = "N";
            bool IsString = true;

            //input

            do
            {
                do
                {
                    Console.WriteLine("please enter your subtotal");
                    Subtot = Console.ReadLine();
                    IsString = Single.TryParse(Subtot, out orderSubTotal);
                    if (!(IsString))
                    {
                        Console.WriteLine("Please enter a valid number");
                    }

                } while (!(IsString));



                //process

                CalculateTax(orderSubTotal, out orderGrandTotal, out stateTaxTotal, out localTaxTotal);

                //output

                Console.WriteLine("Here is your data");
                Console.WriteLine(" Your subTotal is $" + orderSubTotal);
                Console.WriteLine(" Your State Tax is $" + stateTaxTotal);
                Console.WriteLine(" Your Local Tax is $" + localTaxTotal);
                Console.WriteLine(" Your Grande total is $" + orderGrandTotal);
                Console.WriteLine("do you want to with another value Y or N?");

                TryAgain = Console.ReadLine().Substring(0, 1).ToUpper();

            } while (TryAgain == "Y");
        }

        private static void CalculateTax(float orderSubTotal, out double orderGrandTotal, out double stateTaxTotal, out double localTaxTotal)
        {
            Double StateTax = .05;
            Double LocalTax=.03;

            //TODO: Refactor away from magic numbers
            stateTaxTotal = orderSubTotal * StateTax;
            localTaxTotal = orderSubTotal * LocalTax;
            orderGrandTotal = orderSubTotal + stateTaxTotal + localTaxTotal;
        }
    }
}