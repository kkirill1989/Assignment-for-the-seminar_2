// Проверка на палиндром
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
string b = a. ToString();
if(b[0]==b[4] && b[1] == b[3])
{
    Console.WriteLine("Число является палиндромом");
} 
else
{
    Console.WriteLine("Число не является палиндромом");  
}