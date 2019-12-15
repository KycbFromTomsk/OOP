using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Пожалуйста введите адрес объекта");
                string add = Console.ReadLine();

                switch (add)
                {
                    case "Елизаровых 52":
                        Object Placement1 = new Object();
                        Placement1.Address = "Елизаровых 52";
                        Placement1.FireExtinguishingSystem = "СП-есть";
                        Placement1.NotificationSystem = "СО-нет";
                        Placement1.EvacuationPlan = "ПЭ-есть";
                        Placement1.QuantityFireExtinguisher = "огнетушителей-2 шт.";
                        Console.WriteLine(Placement1.AllInformation);
                        break;

                    case "Усова 54":
                        Object Placement2 = new Object();
                        Placement2.Address = "Усова 54";
                        Placement2.FireExtinguishingSystem = "СП-есть";
                        Placement2.NotificationSystem = "СО-есть";
                        Placement2.EvacuationPlan = "ПЭ-нет";
                        Placement2.QuantityFireExtinguisher = "огнетушителей-8 шт.";
                        Console.WriteLine(Placement2.AllInformation);
                        break;

                    case "Пушкина 43":
                        Object Placement3 = new Object();
                        Placement3.Address = "Пушкина 43";
                        Placement3.FireExtinguishingSystem = "СП-нет";
                        Placement3.NotificationSystem = "СО-есть";
                        Placement3.EvacuationPlan = "ПЭ-нет";
                        Placement3.QuantityFireExtinguisher = "огнетушителей-4 шт";
                        Console.WriteLine(Placement3.AllInformation);
                        break;

                    default:
                        Console.WriteLine("Введен неверный адрес объекта");
                        break;
                }
            }
        }       
    }
}
