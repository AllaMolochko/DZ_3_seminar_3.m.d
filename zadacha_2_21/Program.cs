﻿//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Read(string coordinate)
 {   
    System.Console.WriteLine($"Введите координаты двух точек {coordinate}:");    
     int x = int.Parse(Console.ReadLine()); 
    return x;
    } 

    int x1 = Read(x1); 
    int y1 = Read(y1); 
    int z1 = Read(z1);          
    int x2 = Read(x2); 
    int y2 = Read(y2);  
    int z2 = Read(z2);
    
    double Lenght (int x1, int y1, int z1, int x2, int y2, int z2) 

    {
      return Math.Round(Math.Sqrt (Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2)),1));  
    }
System.Console.WriteLine($"Расстояние между двумя точками - {Lenght(x1, y1, x2, y2, z1, z2)}");
