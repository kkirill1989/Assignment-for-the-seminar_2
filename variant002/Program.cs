//
Console.Write ("Введите значение x");
int x = int.Parse(Console.ReadLine () ?? "0");

Console.Write ("Введите знаение y");
int y = int.Parse(Console.ReadLine () ?? "0");

if ((x > 0) && (y > 0))
{
   Console.Write ("Значение находиться в I-ой четверти");    
}
else if ((x < 0) && (y > 0))
{
    Console.Write ("Значение находиться в II-ой четверти");
}
else if ((x < 0) && (y < 0))
{
    Console.Write ("Значение находиться в III- ой четверти");
}
else if ((x > 0) && (y < 0))
{
    Console.Write ("Значение находиться в IV-ой четверти");
}
