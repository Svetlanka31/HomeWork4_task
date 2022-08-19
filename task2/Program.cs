// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//Использование Math.Pow и аналогов = незачёт


Console.WriteLine("Введите число A: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double number2 = Convert.ToDouble(Console.ReadLine());
 double number = 1;
 if (number2 > 1)
 {
    for(int i = 0; i< number2; i++)
    {
     number *=number1; 
    }
    
Console.WriteLine(number);
}
if (number2 < 1)
{
    Console.WriteLine("Степень, в которую возводят число не является натуральной");
}