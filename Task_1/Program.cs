Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
int min = secondNumber;
if (firstNumber > max) max= firstNumber;
if (secondNumber > max) max= secondNumber;
if (secondNumber < min) min= secondNumber;
if (firstNumber < min) min= firstNumber;
Console.Write ("max =");
Console.WriteLine (max);
Console.Write ("min =");
Console.WriteLine (min);


