
        double allTotal = 0;
        int choice;

        do
        {
            System.Console.Write("Enter price: ");
            double price = System.Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("Enter quantity: ");
            int quantity = System.Convert.ToInt32(System.Console.ReadLine());

            double total = price * quantity;
            System.Console.WriteLine("Total = " + total);

            allTotal += total;

            System.Console.Write("Add another product? 1 = Yes, 0 = No: ");
            choice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (choice == 1);

        System.Console.WriteLine("All Total = " + allTotal);
    