using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CYCLES_PART2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = METHODS.RandomNumberGenerator();
            Console.WriteLine("Guess the random number!");
            Console.WriteLine($"(it's {secretNumber})");
            bool isGuessed = METHODS.Guess(secretNumber);

            if (!isGuessed)
            {
                Console.WriteLine("wrong, try again.");
            }
            else
            {
                Console.WriteLine("YAY!! NO WAY! you're lucky!");
            }

            int firstNumber = METHODS.Numberss();
            int secondNumber = METHODS.Numberss();
            Console.WriteLine($"it's {firstNumber} aaand {secondNumber}.");

            if (firstNumber == 6 || secondNumber == 7) { Console.WriteLine("wow very funny."); }
            else if (firstNumber == 8 || secondNumber == 3) { Console.WriteLine("I love this becauce it looks like cute face! 83"); }

            Console.WriteLine("What do you want me to do with them?");

            string dd = Console.ReadLine();
            if (dd == "+") { int plus = firstNumber + secondNumber; Console.WriteLine(plus); }
            else if (dd == "-") { int minus = firstNumber - secondNumber; Console.WriteLine(minus); }
            else if (dd == "*") { int umn = firstNumber * secondNumber; Console.WriteLine(umn); }
            else if (dd == "/") { int slash = firstNumber / secondNumber; Console.WriteLine(slash); }
            else { Console.WriteLine("WHAAAt the hell is this? I'm out. I do not calculate."); }

            Console.WriteLine("ДАВАЙ ПРОТЕСТИРУЕМ ТЕБЯ НА ЗНАНИЕ О BLOCK TALES!");

            int points = 0;

            Console.WriteLine("Вопрос 1. Кто похитил билдермена?");
            Console.WriteLine("a) Джон Файтинг б) Загадочная фигура в) Дуссекар г) Дум");
            string theAnswer1 = Console.ReadLine();
            if (theAnswer1 == "б" || theAnswer1 == "Б") {points++; Console.WriteLine($"Правильно! Твой балл: {points}");}
            else {Console.WriteLine("Правильный ответ б.");}


            Console.WriteLine("Вопрос 2. Почему Грифер хотел помешать игроку?");
            Console.WriteLine("a) Он ему завидовал. б) У него нет матери. в) Загадочная фигура манипулировала им. г) Он же грифер. ");
            string theAnswer2 = Console.ReadLine();
            if (theAnswer2 == "в" || theAnswer2 == "d") {points++; Console.WriteLine($"Правильно! Твой балл: {points}");}
            else {Console.WriteLine("Правильный ответ в.");}

            Console.WriteLine("Вопрос 3. Кто такие Зеленый и Фиолетовая?");
            Console.WriteLine("a) Родители красного и голубой. б) Враги Нубадора. в) Задиры и разбойники. г) Главные злодеи 3 главы. ");
            string theAnswer3 = Console.ReadLine();
            if (theAnswer3 == "а" || theAnswer3 == "a") {points++; Console.WriteLine($"Правильно! Твой балл: {points}");}
            else {Console.WriteLine("Правильный ответ a.");}

            Console.WriteLine("Вопрос 4. За что Нубадор просил прощения у игрока?");
            Console.WriteLine("a) За кражу мяча. б) За то что он, красный и синяя хотели побить игрока. в) Он проиграл в соревновании. г) Он пообещал игроку поймать кита, но не смог. ");
            string theAnswer4 = Console.ReadLine();
            if (theAnswer4 == "б" || theAnswer4 == "Б") {points++; Console.WriteLine($"Правильно! Твой балл: {points}");}
            else {Console.WriteLine("Правильный ответ б.");}

            Console.WriteLine("Вопрос 5. Как зовут минибосса джина из 5 главы?");
            Console.WriteLine("a) Зе Вондерфул Флосси. б) Зе Флосси. в) Зе Грейт Флосси. г) Зе Алмайгти Флосси.");
            string theAnswer5 = Console.ReadLine();
            if (theAnswer5 == "в" || theAnswer5 == "d") {points++; Console.WriteLine($"Правильно! Твой балл: {points}");}
            else {Console.WriteLine("Правильный ответ в.");}

            Console.WriteLine($"Твой результат: {points}.");
            if (points == 5) { Console.WriteLine("Воу, да ты шаришь."); }
            else if (points == 4) { Console.WriteLine("Уважаемо."); }
            else if (points == 3) { Console.WriteLine("Неплохо."); }
            else { Console.WriteLine("Скорее всего ты не играл ТсТ"); }
        }
    }
}