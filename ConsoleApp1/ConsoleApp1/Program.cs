using System.ComponentModel.Design;

string membership = Console.ReadLine();

if (membership == "Gold")
{
    Console.WriteLine("Welcome, Gold Member!");
}
else if (membership == "Silver")
{
    Console.WriteLine("Welcome, Silver Member!");
}

else
{     Console.WriteLine("Welcome, Guest!");
}

string message = membership == "Gold" ? "Welcome, Gold Member!" :
                 membership == "Silver" ? "Welcome, Silver Member!" :
                 "Welcome, Guest!";
Console.WriteLine(message);

double discount = membership == "Gold" ? 0.20 :
                  membership == "Silver" ? 0.10 :
                  0.0; 

Console.WriteLine($"Your discount is: {discount:P2}");
double pre_discount_price = 100.0;
double final_price = pre_discount_price * (1 - discount);
Console.WriteLine($"The Final price is: {final_price:F2}");