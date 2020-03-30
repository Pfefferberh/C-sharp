using System;
//Задание 1. Реализовать программу “Строительство дома”
//Реализовать:
//•	 Классы
//■ House(Дом), Basement(Фундамент), Walls(Стены),
//Door(Дверь), Window(Окно), Roof(Крыша);
//■ Team(Бригада строителей), Worker(Строитель),
//TeamLeader(Бригадир).
//•	 Интерфейсы
//■ IWorker, IPart.
//Все части дома должны реализовать интерфейс IPart
//(Часть дома), для рабочих и бригадира предоставляется
//базовый интерфейс IWorker(Рабочий).
//Домашнее задание №6 Домашнее задание №<Номер дз>
//Бригада строителей(Team) строит дом(House). Дом
//состоит из фундамента(Basement), стен(Wall), окон
//(Window), дверей(Door), крыши(Part).
//Согласно проекту, в доме должно быть 1 фундамент,
//4 стены, 1 дверь, 4 окна и 1 крыша.
//Бригада начинает работу, и строители последовательно
//“строят” дом, начиная с фундамента.Каждый строитель
//не знает заранее, на чём завершился предыдущий этап
//строительства, поэтому он “проверяет”, что уже построено и продолжает работу.Если в игру вступает бригадир
//(TeamLeader), он не строит, а формирует отчёт, что уже
//построено и какая часть работы выполнена.
//В конечном итоге на консоль выводится сообщение, что
//строительство дома завершено и отображается “рисунок
//дома” (вариант отображения выбрать самостоятельно).

namespace HT_home_build
{
    class Program
    {
        static void Main(string[] args)
        {
            Basement basement = new Basement(1);
            uint BasementCount = basement.PartsCount;

            Walls walls = new Walls(4);
            uint wallsCount = walls.PartsCount;

            Door doors = new Door(1);
            uint doorsCount = doors.PartsCount;

            Window windows = new Window(4);
            uint windowsCount = windows.PartsCount;

            Roof roofs = new Roof(1);
            uint roofsCount = roofs.PartsCount;

            House house = new House(BasementCount, wallsCount, doorsCount, windowsCount, roofsCount);
            house.ShowHouse();
        }
    }
}
