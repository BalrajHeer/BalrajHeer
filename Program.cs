using System.ComponentModel.Design;
do
{
    Console.WriteLine("Please enter your name:-");
    string name = Console.ReadLine().ToUpper();
    byte tc = 0;
    byte sl = 0;
    byte de = 0;
    byte ex = 0;
    byte t;
    do
    {
        Console.WriteLine($"What can I get you {name} ?\na.Turkish Coffee(3.35$)\nb Double Espresso(3.25$)\nc.Spanish Latte(4.80$)");
        char input = Convert.ToChar(Console.ReadLine().ToLower());

        switch (input)
        {
            case 'a':
                do
                {
                    Console.WriteLine("How many Turkish Coffees would you like?(1-5)");
                    t = Convert.ToByte(Console.ReadLine());                    
                } while (t > 5);
                tc += t;
                break;
            case 'b':
                Console.WriteLine("Adding a Double Espresso to your order.");
                do
                {
                    de++;
                    Console.WriteLine("Would you like some Whipped Cream with it? (y/n)");
                    if (Convert.ToChar(Console.ReadLine()) == 'y')
                    {
                        Console.WriteLine("That’ll be an extra 0.75$. Do you want to proceed with the extra charge? (y/n)");
                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            ex++; Console.WriteLine("ok");
                        }
                        else
                        {
                            Console.WriteLine("Sorry then you have take without whipped cream.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Double Espresso without whipped cream done");
                    }
                    Console.WriteLine("Would you like to add another Double Espresso(y/n)?");
                } while (Convert.ToChar(Console.ReadLine()) == 'y');
                break;
            case 'c':                
                    do
                    {
                        sl++;
                        Console.WriteLine("Adding Spanish Latte to your order");
                        Console.WriteLine("Would you like to add another Spanish Latte? (y/n)");
                    } while (Convert.ToChar(Console.ReadLine()) == 'y');
                    Console.WriteLine($"You have added {sl} Spanish Latte to your order.");
                break;
            default: Console.WriteLine("Invalid Input");
                break;
        }
        Console.WriteLine("Would you like to add another beverage to your order?(y/n)");
    } while (Convert.ToChar(Console.ReadLine()) == 'y');
    Console.WriteLine($"Your order summary:\n{tc} Turkish Coffees @ {tc * 3.35}$" +
        $"\n{sl} Spanish Latte @ {sl * 4.80}$"
        + $"\n{de} Double Espresso @{de * 3.25}$ {ex} Whipped Cream @ {ex * .75}$"
        + $"\nTotal = {tc * 3.35 + sl * 4.80 + de * 3.25 + ex * .75}$");
    if (tc * 3.35 + sl * 4.80 + de * 3.25 + ex * .75 > 0)
    {
        Console.WriteLine("Please enter your 16-digits credit card number:");
        int ccn = Convert.ToInt32(Console.ReadLine());
        byte m;
        byte y;
        do
        {
            Console.WriteLine("Please enter the month (MM) and year (YY) of expiration –");
            m = Convert.ToByte(Console.ReadLine());
            y = Convert.ToByte(Console.ReadLine());
            if (m < 11 && y < 23 || m > 11 && y > 28)
            {
                Console.WriteLine("Sorry, this is invalid.Valid expiration range between November 2023 and November 2028");
            }
            else
            {
                Console.WriteLine("Please enter your 3-digits CCV:");
            }
        } while (m < 11 && y < 23 || m > 11 && y > 28);
        int CCV = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine($"Thank you for visiting B.Hive, Michelle! We will call your {name}\r\nwhen your order is ready. Have a great day!\r\n********** Welcome to B.Hive! **********");
    }
} while (true);