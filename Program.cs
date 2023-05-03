/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
3 → 1,4,9

*/


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
{
    int newNumber = (int)Math.Pow(i, 3); // (int) - строгое преобразование , че бы там не было мы приказываем ему стать int -om
    Console.WriteLine(newNumber);
}