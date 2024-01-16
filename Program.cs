using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Компьютерный практикум № 13 (на зимние каникулы)
            //1. Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа,
            //ввести с экрана вариант ответа. Программа должна оценить ответ и в случае неправильного ответа написать правильный.
            /*
            Console.WriteLine("Кто написал произведение \"Мастер и Маргарита\" ?");
            Console.WriteLine("1)М.А. Булгаков\n2)Л.Н. Толстой\n3)Ф.М. Достоевский");
            Console.Write("Ваш ответ: ");
            string UserAnswer = Console.ReadLine();
            switch (UserAnswer)
            {
                case "М.А. Булгаков":
                    Console.WriteLine("Ответ правильный !");break;
                case "Михаил Булгаков":
                    Console.WriteLine("Ответ правильный !"); break;
                case "Булгаков":
                    Console.WriteLine("Ответ правильный !"); break;
                case "1":
                    Console.WriteLine("Ответ правильный !"); break;
                case "1)":
                    Console.WriteLine("Ответ правильный !"); break;
                default: Console.WriteLine("Ответ неправильный"); break;
            }
            */

            //2.Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям предоставляется 20 % скидка.
            //Ввести продолжительность разговора и день недели(цифра от 1 до 7).
            /*
            double CostpMinute = 10.0;
            double discount = 0.2;            
            Console.Write("Введите день недели: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите продолжительность переговоров в минутах: ");
            double duration = Convert.ToDouble(Console.ReadLine());
            double cost = duration * CostpMinute;
            if (day == 7 || day == 6)
            {
                cost = cost * discount;
                Console.WriteLine($"Стоимость: {cost}");
            }
            else
            {
                Console.WriteLine($"Стоимость: {cost}");
            }
            */

            //3. Написать программу для определения времени суток по данному текущему времении  вывести сообщение
            //(утро – с 6 до 12, день – с 12 до 18, вечер – с 18 до 24, ночь – с 0 до 6).

            /*
            Console.Write("Введите время: ");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time <= 6)
            {
                Console.WriteLine("Ночь");
            }
            else if (time >= 6 && time <= 12)
            {
                Console.WriteLine("Утро");
            }
            else if (time >= 12 && time <= 18)
            {
                Console.WriteLine("День");
            }
            else { Console.WriteLine("Вечер"); }
            */


            //4
            // Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется
            // средним баллом по диплому, умноженным на коэффициент стажа работы по специальности,
            // который равен: нет стажа – 1, меньше 2 лет – 13, от 2 до 5 лет – 16.
            // Составить программу расчета рейтинга при заданном среднем балле диплома (от 3 до 5)
            // вывести сообщение о приеме в магистратуру при проходном балле 45.

            /*
            Console.Write("Введите ваш средний балл диплома: ");
            double mark = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш стаж работы: ");
            double experience = Convert.ToDouble(Console.ReadLine());
            double coeff;
            if (experience < 0)
            {
                coeff = 1;
            }
            else if (experience <= 2)
            {
                coeff = 13;
            }
            else  coeff = 16; 

            double rating = mark * coeff;
            if (rating < 45) { Console.WriteLine("Вы не приняты в магистратуру "); }
            else { Console.WriteLine("Вы приняты в магистратуру " ); }
            */

            //5

            //Написать программу, которая по дате рождения(день d месяц n) определяет знак Зодиака:
            //с 22 марта по 21 апреля - Овен(4); с 22 апреля по 21 мая - Телец(5); с 22 мая по 21 июня - Близнецы(6);
            //с 22 июня по 21 июля - Рак(7); с 22 июля по 21 августа - Лев(8); с 22 августа по 21 сентября - Дева(9);
            //22 сентября по 21 октября - Весы(10); с 22 октября по 21 ноября - Скорпион(11); с 22 ноября по 21 декабря - Стрелец(12);
            //с 22 декабря по 21 января - Козерог(1); 22 января по 21 февраля - Водолей(2); с 22 февраля по 21 марта - Рыбы(3).


            /*
            Console.Write("Введите дату вашего дня рождения (день)");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Введите дату вашего дня рождения (месяц)");
            int month = int.Parse(Console.ReadLine());
            string zodiac = "";
            switch (month)
            {
                case 1:
                    zodiac = (day < 22) ? "Козерог":"Водолей";
                    break;
                case 2:
                    zodiac = (day < 22) ? "Водолей":"Рыбы";
                    break;
                case 3:
                    zodiac = (day < 22) ? "Рыбы":"Овен";
                    break;
                case 4:
                    zodiac = (day < 22) ? "Овен":"Телец";
                    break;
                case 5:
                    zodiac = (day < 22) ? "Телец":"Близнецы";
                    break;
                case 6:
                    zodiac = (day < 22) ? "Близнецы":"Рак";
                    break;
                case 7:
                    zodiac = (day < 22) ? "Рак":"Лев";
                    break;
                case 8:
                    zodiac = (day < 22) ? "Лев":"Дева";
                    break;
                case 9:
                    zodiac = (day < 22) ? "Дева":"Весы";
                    break;
                case 10:
                    zodiac = (day < 22) ? "Весы":"Скорпион";
                    break;
                case 11:
                    zodiac = (day < 22) ? "Скорпион":"Стрелец";
                    break;
                case 12:
                    zodiac = (day < 22) ? "Стрелец":"Козерог";
                    break;
            }

            Console.WriteLine($"Ваще знак: {zodiac}");
            */

            //6
            //Написать программу, которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово
            //"копейка" в правильной форме. Например, 1 копейка, 5 копеек, 42 копейки.

            /*
            Console.Write("Введите кол-во копеек от 1 до 99: ");
            byte numb = byte.Parse(Console.ReadLine());
            string kopeck;
            int lastDigit = numb % 10;
            if (numb >= 5 && numb <= 20)
            {
                kopeck = "копеек";
            }
            else if (lastDigit == 1)
            {
                kopeck = "копейка";
            }
            else if (lastDigit >= 2 && lastDigit <= 4)
            {
                kopeck = "копейки";
            }
            else
            {
                kopeck = "копеек";
            }
            Console.WriteLine(numb + " " + kopeck);
            */


            //7. Написать программу, которая после введенного с клавиатуры числа в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.


            Console.Write("Введите кол-во рублей от 1 до 99: ");
            byte numb = byte.Parse(Console.ReadLine());
            string rubles;
            int lastDigit = numb % 10;
            if (numb >= 11 && numb <= 14)
            {
                rubles = "рублей";
            }
            else if (lastDigit == 1)
            {
                rubles = "рубль";
            }
            else if (lastDigit >= 2 && lastDigit <= 4)
            {
                rubles = "рубля";
            }
            else
            {
                rubles = "рублей";
            }
            Console.WriteLine(numb + " " + rubles);
        }
    }
}
