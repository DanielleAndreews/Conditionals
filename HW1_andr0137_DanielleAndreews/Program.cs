using System;

class Program
{

    /* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            // Please write down your name first. 
            Console.WriteLine("My name is xxx xxx. My OU 4x4 is xxx, and my GitHub account name is @xxxxxx. \n");

            Console.WriteLine("=== CALCULATOR SYSTEM ===");
            Console.WriteLine("1) Calculate Sale Total");
            Console.WriteLine("2) Calculate Student Grade");
            Console.WriteLine("3) Exit");
            Console.Write("\nSelect an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                SaleTotal();
            }
            else if (input == "2")
            {
                StudentGrade();
            }
            else if (input == "3")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }

    // --- Question 1 ---

    static void SaleTotal()
    {
        Console.Clear();
        Console.WriteLine("--- Sale Total Calculator ---");

        const double Sales_tax_rate = 0.005;

        Console.WriteLine("What is the type of item you are purchasing?");
        String item = Console.ReadLine();

        Console.WriteLine("What is the quantity for the item?");
        int quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the price of the item?");
        double price = double.Parse(Console.ReadLine());

        double subtotal = quantity * price;
        double sales_tax = subtotal * Sales_tax_rate;
        double total = subtotal + sales_tax;

        Console.WriteLine("\nItem:" + item);
        Console.WriteLine("Your subtotal for the bill is: $" + subtotal.ToString("0.00"));
        Console.WriteLine("Your sales tax for the bill is: $" + sales_tax.ToString("0.00"));
        Console.WriteLine("Your total for the bill is: $" + total.ToString("0.00"));




        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Question 2 ---

    static void StudentGrade()
    {
        Console.Clear();
        Console.WriteLine("--- Student Grade Calculator ---");

        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine("What is your student ID?");
        int Student_ID = int.Parse(Console.ReadLine());
        
        Console.WriteLine("What is your overall percentage grade for homework?");
        double Homework = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for participation?");
        double Participation = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for quizzes?");
        double Quizzes = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for the midterm");
        double Midterm = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for quizzes?");
        double Final  = double.Parse(Console.ReadLine());

        const double Homework_percentage = .20;
        const double Participation_percentage = .20;
        const double Quizzes_percentage = .20;
        const double Midterm_percentage = .20;
        const double Final_percentage = .20;

        double Final_Grade = ((Homework * Homework_percentage) + (Participation * Participation_percentage) + (Quizzes * Quizzes_percentage) + (Midterm * Midterm_percentage) + (Final * Final_percentage));

        Console.WriteLine("\nStudent: " + firstName + " " + lastName);
        Console.WriteLine("Student ID: " + Student_ID);
        Console.WriteLine("Final Grade: " + Final_Grade.ToString("0.00") + "%");


        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}