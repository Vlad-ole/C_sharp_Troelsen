using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Сымитировать управление лентой конвейера.

namespace Chapter_12
{
    class ConveyorControl
    {
        // Перечислить команды конвейера.
        public enum Action { Start, Stop, Forward, Reverse };
        public void Conveyor(Action com)
        {
            switch (com)
            {
                case Action.Start:
                    Console.WriteLine("Запустить конвейер.");
                    break;
                case Action.Stop:
                    Console.WriteLine("Остановить конвейер.");
                    break;
                case Action.Forward:
                    Console.WriteLine("Переместить конвейер вперед.");
                    break;
                case Action.Reverse:
                    Console.WriteLine("Переместить конвейер назад.");
                    break;
            }
        }
    }

    class Prog_15
    {
        static void Main()
        {
            ConveyorControl с = new ConveyorControl();
            с.Conveyor(ConveyorControl.Action.Start);
            с.Conveyor(ConveyorControl.Action.Forward);
            с.Conveyor(ConveyorControl.Action.Reverse);
            с.Conveyor(ConveyorControl.Action.Stop);

            Console.ReadKey();
        }
    }
}
