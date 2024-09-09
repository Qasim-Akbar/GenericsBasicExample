
int x = 12;
int y = 13;
Swap(ref x,ref y);
Console.WriteLine($"x={x}, y={y}");

string firstName = "Bakar";
string secondName = "Ali";

Swap(ref firstName, ref secondName);
Console.WriteLine($"firstName={firstName}, secondName={secondName}");

//Generic Function
void Swap<T>(ref T a, ref T b)
{
    T temp = a; a = b; b = temp;
}