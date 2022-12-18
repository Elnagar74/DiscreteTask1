                            // محمود ابراهيم محمد النجار
Console.Write("Enter The First Number: ");
int Start_Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter The Second Number: ");
int End_Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------------");
Console.WriteLine("The Prime Numbers between {0} and {1}", Start_Number, End_Number);
Console.WriteLine("-----------------------------------");
int x;
bool prime = true;

for (; Start_Number < End_Number; Start_Number++)
{
    for ( x = 2; x < Start_Number; x++)
    {
        if (Start_Number % x == 0)
        {
            prime = false;
            break;
        }
    }
    if (prime == true && Start_Number != 1 && Start_Number > 0)
    { 
        Console.WriteLine(x); 
    }
    prime = true;
}
Console.WriteLine("");