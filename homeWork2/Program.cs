bool stillIn = true;
int num1 = 0;
int operacion = 0;
int num2 = 0; 
while (stillIn)
{
    Console.WriteLine("would you like to check a numbe? ");
    Console.WriteLine("\n.1.Yes\n.2.no ");
    try
    {
         num1 = int.Parse(Console.ReadLine()!);
    }
    catch(Exception e)
    {
        Console.WriteLine("Letters are unceptable, please write a number or tray later ");
        continue; 
    }
   

    switch (num1)
    {
        case 1:
            {
                num2 = NumberChecked();
                Console.WriteLine($"{Checknumber(num2)}"); 

            }
            break;
        case 2:
            {
                Console.WriteLine("You have left the program ");
                stillIn = false;
                
            }
            break;
        
        default:
            {
                Console.WriteLine("You gotta try again ");
            }
            break;
    }
}
static string Checknumber(int number)
{
    string message = number % 2 == 0 ? "the  number is par" : "The number is impar";
    return message; 
}
static int NumberChecked()
{
    Console.WriteLine("Write the number that you want to check ");
    int num1 = 0;
    try
    {

        
         num1 = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.WriteLine("Just number are aceptable, please try again");
         
    }
    return num1;

}

