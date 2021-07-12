using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatternDemo
{
    /// <summary>
    /// Receiver class
    /// </summary>
    public class Activity
    {
        public string ID { get; set; }
        public int Availability { get; set; }

        public Activity(string id, int availability)
        {
            ID = id;
            Availability = availability;
        }

        public void IncreaseAvailability(int value)
        {
            Availability += value;
            Console.WriteLine($"El cupo para la actividad #{ID} ha sido aumentado en {value}.");
        }

        public void DecreaseAvailability(int value)
        {
            if (value < Availability)
            {
                Availability -= value;
                Console.WriteLine($"El cupo para la actividad #{ID} ha sido reducido en {value}.");
            }
        }

        public override string ToString() => $"El cupo para la actividad #{ID} es de {Availability}.";
    }
}
