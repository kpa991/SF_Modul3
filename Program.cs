﻿using System;

namespace Modul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay);

        }
    } 
    enum DaysOfWeek : byte
    {
        Tuesday,
        Monday,
        Wednesday,
        Friday
    }
}
  

