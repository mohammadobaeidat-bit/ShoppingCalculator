
        double allTotal = 0;
        int choice;

        do
        {
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double total = price * quantity;
            Console.WriteLine("Total = " + total);

            allTotal += total;

            Console.Write("Add another product? 1 = Yes, 0 = No: ");
            choice = Convert.ToInt32(Console.ReadLine());

        } while (choice == 1);

        Console.WriteLine("All Total = " + allTotal);
    
