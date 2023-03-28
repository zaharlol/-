﻿class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();

        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }
    }

    static Department GetCurrentDepartment()
    {

    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
}