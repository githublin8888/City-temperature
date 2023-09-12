


string answer = "1";
double balance = 0;

while (answer == "1")
{
    Console.WriteLine("===Welcome===");
    Console.WriteLine("Make a choice: ");
    Console.WriteLine("1. Deposit"
           + "\r\n" + "2. Withdraw"
           + "\r\n" + "3. Balance"
           + "\r\n" + "4. Investment"
           + "\r\n" + "5. Exit");

    string choice = Console.ReadLine();


    switch (choice)

    {

        case "1":
            double Deposit = 0;
            Console.WriteLine("Enter the amount: ");
            Deposit = Convert.ToDouble(Console.ReadLine());
            balance = balance + Deposit;

            if (Deposit <= 0) //to control the value is > 0
            {
                Console.WriteLine("The amount should be bigger than 0");
                Console.WriteLine("Enter again: ");
                Deposit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("You deposit: " + Deposit);

            }
            else
            {
                Console.WriteLine("You deposit: " + Deposit);
            }

            break;


        case "2":
            double Withdraw = 0;
            Console.WriteLine("Enter the amount: ");
            Withdraw = Convert.ToDouble(Console.ReadLine());
            balance = balance - Withdraw;

            if (Withdraw <= 0)
            {
                Console.WriteLine("The amount should be bigger than 0");
                Console.WriteLine("Enter again: ");
                Withdraw = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("You will withdraw: " + Withdraw);
            }
            else
                Console.WriteLine("You will withdraw: " + Withdraw);

            break;

        case "3":

            Console.WriteLine("You balance is: " + balance);

            break;

        case "4":
            // users enter the deposit amount, an interest rate and the number of years they want to save

            Console.WriteLine("Enter the amount: ");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years do you want to save: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an interest rate % (an integer): ");
            double interest = 0.01 * Convert.ToDouble(Console.ReadLine());



            if (deposit <= 0 || year <= 0 || interest <= 0) //to control the value is >0
            {
                Console.WriteLine("Enter a figure bigger than 0");
            }
            else
            {
                int i = 1; // year  
                while (i <= year)
                {
                    double money = deposit * (1 + interest);// to calculate the sum of annual savings (deposit) and annual return (interest)
                    deposit = money; // the sum becomes next year's deposit

                    i = i + 1;
                }

                Console.WriteLine("You will have: " + deposit + "kr");

            }
            break;

        case "5":
            Console.WriteLine("Thank you! Bye!");
            break;

        default:
            Console.WriteLine("Choose a number: 1/2/3/4/5"); // to control that the user enter the right number to make a choice
            break;


    }

    Console.WriteLine("Back to mune or exit? "
                         + "\r\n" + "1. back; "
                         + "\r\n" + "2. exit");

    answer = Console.ReadLine();

    if (answer == "2")
    {
        Console.WriteLine("Thank you! Bye!");
        break;
    }

    else
    {
        answer = "1";
    }


}



















