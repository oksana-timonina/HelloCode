﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Ура, это же Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!");
}