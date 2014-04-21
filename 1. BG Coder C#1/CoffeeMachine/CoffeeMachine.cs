using System;

class CoffeeMachine
{

    //                  96/100

    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        double cent5 = n1 * 0.05;
        double cent10 = n2 * 0.10;
        double cent20 = n3 * 0.20;
        double cent50 = n4 * 0.50;
        double cent100 = n5 * 1.00;
        double totalMoney = cent5 + cent10 + cent20 + cent50 + cent100;
        //double totalMoney = 3.50;
        double inputMoney = double.Parse(Console.ReadLine());
        double drinkPrice = double.Parse(Console.ReadLine());
        if (totalMoney > inputMoney - drinkPrice && drinkPrice < inputMoney)
        {
            Console.WriteLine("Yes {0:F2}", (totalMoney - (inputMoney - drinkPrice)));
        }
        else if (drinkPrice > inputMoney)
        {
            Console.WriteLine("More {0:F2}",drinkPrice-inputMoney );
        }
        else if (totalMoney < inputMoney-drinkPrice )
        {
            Console.WriteLine("No {0:F2}", (inputMoney-drinkPrice) - totalMoney );
        }
        else if (totalMoney==(inputMoney-drinkPrice))
        {
            Console.WriteLine("Yes {0:F2}", totalMoney);
        }
    }
}

