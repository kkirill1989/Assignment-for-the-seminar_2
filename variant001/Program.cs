Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 7;
int c = 23;

if(a% b == 0 && a % c == 0)
{
  Console.WriteLine("Заданное число кратно 7 и 23");
}
else
{
  Console.WriteLine("Заданное число не кратно 7 и 23");   
}
