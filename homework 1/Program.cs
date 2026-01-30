int Num1 = 10;
string Num2 = "Richard Terrero Reilly ";
bool Num3 = false;
double Num4 = 45.085;

Console.WriteLine($"The value of your intiger variable is : {Num1}");
Console.WriteLine($"The value of your string variable is: {Num2}");
Console.WriteLine($"The value of your boll variable is: {Num3}");
Console.WriteLine($"The value of your double type variable is: {Num4}");


const int valor1 = 25;
Console.WriteLine($"The value of your const is: {valor1}");
// valor1 = 5;
Console.WriteLine($"The value of your variable is: {valor1}");

//intiger type declaration
int incre1 = 20;
int incre2 = 10;
Console.WriteLine($"The value of your variable before being incrised: {incre1}");
for (int i= 0; incre1 < 21; i++)
{
    incre1++;
}
Console.WriteLine($"The value of your variable before being dicrised {incre2}");

for(int i = 10; incre2 > 1; i--)
{
    incre2--; 
}
Console.WriteLine($"{ incre1} { incre2}");
Console.WriteLine($"The sum of your intiger variable is: {incre1 + incre2}");

float dent1 = 10152466.25f;
byte dent2 = 5;
byte sum = (byte)(dent1 + dent2);
Console.WriteLine($"The result of your byte sum is: {sum}");
// this is a coment just using one line. 
/*This 
is a coment where we can use more than one line 
*/
DateTime Time = DateTime.Now;
Console.WriteLine($"The date of your homework is {Time} "); 


    Console.ReadKey();