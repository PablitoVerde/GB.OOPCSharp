using System;
using System.Collections.Generic;
using System.Text;

/*
 * *1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). 
 *Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. 
 *Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
 *Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть 
 *статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал 
 *бы значение этого поля. 
 */

namespace Lesson4
{
    internal class Building
    {
        static int BuildingID = 1;
        //Поля кдасса
        private int id;
        private double height;
        private int floorCount;
        private int flatCount;
        private int entranceCount;

        // Свойства класса
        public int Id { get; private set; }
        public double Height { get { return height; } private set { height = value; } }
        public int FloorCount { get { return floorCount; } private set { floorCount = value; } }
        public int FlatCount { get { return flatCount; } private set { flatCount = value; } }
        public int EntranceCount { get { return entranceCount; } private set { entranceCount = value; } }

        public Building(double height, int floorCount, int flatCount, int entranceCount)
        {
            Id = NewID();
            Height = height;
            FloorCount = floorCount;
            FlatCount = flatCount;
            EntranceCount = entranceCount;
        }

        public double floorHeight()
        {
            return height / floorCount;
        }

        public int flatOnFloor()
        {
            return flatOnBlock() / floorCount;
        }

        public int flatOnBlock()
        {
            return flatCount / EntranceCount;
        }

        public int NewID ()
        {
            return BuildingID++;
        }
    }
}
