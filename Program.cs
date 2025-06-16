class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(
            "Choose an option to start running a program:\n1. Factorial\n2. Calculator\n3. Menu Driven Program\n4. Class Hierarchy\n5. Payment Gateway\n6. Employee Manager\n7. Exit "
        );
        string userInput = Console.ReadLine() ?? "";
        switch (userInput)
        {
            case "1":
                Factorial factorial = new Factorial();
                factorial.getFactorial();
                break;
            case "2":
                Calculator calculator = new Calculator();
                calculator.calculate();
                break;
            case "3":
                EmployeeManagement employee = new EmployeeManagement();
                employee.getUserInput();
                break;
            case "4":
                Vehicle car = new Car(2025, 5, "KIA");
                Vehicle bus = new Bus(2020, 50, "Volvo");
                Vehicle bike = new Bike(2021, 2, "TVS Motor");

                Vehicle[] vehicles = { car, bus, bike, };

                foreach (var v in vehicles)
                {
                    v.DisplayInformation();
                    v.Start();
                    v.Stop();
                    Console.WriteLine();
                }
                break;
            case "5":
                PaymentGateway processor = new PaymentGateway();

                PaymentMethod paypal = new PayPalPayment("merchant_001", "merchant@123");
                processor.MakePayment((IPaymentGateway)paypal, 1500, "cust_001", "PayPal");
                paypal.ShowProviderInfo();
                processor.CheckStatus((IPaymentGateway)paypal, "transaction_001");
                processor.MakeRefund((IPaymentGateway)paypal, 1500, "transaction_001");
                // Console.WriteLine();
                // PaymentMethod creditCard = new CreditCardPayment("merchant_003", "1234567812345678");
                // processor.MakePayment((IPaymentGateway)creditCard, 3200, "cust_002", "CreditCard");
                // creditCard.ShowProviderInfo();
                // processor.CheckStatus((IPaymentGateway)creditCard, "transaction_004");
                // processor.MakeRefund((IPaymentGateway)creditCard, 3200, "transaction_004");
                break;
            case "6":
                EmployeeApp empApp = new EmployeeApp();
                empApp.GetUserInput();
                break;
            case "7":
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}