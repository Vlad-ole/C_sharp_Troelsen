﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Программа, в которой используется класс Building.

namespace Chapter_6
{
    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов
    }

    // В этом классе объявляется объект типа Building.
    class BuildingDemo 
    {
        static void Main() 
        {
            Building house = new Building(); // создать объект типа Building
            int areaPP; // площадь на одного человека
            // Присвоить значения полям в объекте house.
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;
            // Вычислить площадь на одного человека.
            areaPP = house.Area / house.Occupants;

            Console.WriteLine("Дом имеет:\n " +
             house.Floors + " этажа\n " +
             house.Occupants + " жильца\n " +
             house.Area +
             " кв. футов общей площади, из них\n " +
             areaPP + " приходится на одного человека");

            Console.ReadKey();
        }

    }
}
