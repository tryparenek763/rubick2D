using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace rubick2D
{
    class Rectangle
    {
        private float _length, _width; // поля класса

        public Rectangle(float length, float width)   // конструктор прямоугольник с входными параметрами длина и ширина
        {
            _length = length;  //в поле класса записывается значение входящего параметра
            _width = width;    //в поле класса записывается значение входящего параметра
        }

        public float MinSide() // Метод возращающий минимальную сторону прямоугольника
        {
            if (_length < _width)
            {
                return _length;
            }

            return _width;
        }
    }

    class Program 
    {
        public void Main() //Главный метод программы
        {
            Rectangle[] myArray = new Rectangle[80]; // Выделяем 80 ячеек памяти 
            Random random = new Random(); // создается рандомизатор

            float sum = 0; // Счетчик

            for (int i = 0; i < myArray.Length; i++) // Заполнение массива
            {
                myArray[i] = new Rectangle(random.Next(10, 90), random.Next(10, 90)); // в i ячейку записывается прямоугольник с рандомными сторонами от 10-90
                sum = myArray[i].MinSide() + sum; // Добавление наименьшой стороны к сумме
            }
        }
    }
}