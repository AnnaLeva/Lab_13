using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_13_Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            string adress = Console.ReadLine();
            string length = Console.ReadLine();
            string width = Console.ReadLine();
            string height = Console.ReadLine();
            string flor = Console.ReadLine();
            Building building = new Building(adress, length, width, height);
            BuildingApd buildingApd = new BuildingApd(adress, length, width, height, flor);
            building.Print();
            buildingApd.Print();
            Console.ReadKey();
        }
    }

    class Building
    {
        public string Adress { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Aheight { get; set; }

        public Building()
        {

        }

        public Building(string adress, string length, string width, string aheight)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Aheight = aheight;
        }

        public void Print()
        {
            Console.WriteLine("Adress {0}, length {1}, width{2}, aheight{3}", Adress, Length, Width, Aheight);
        }
    }
    sealed class BuildingApd : Building
    {
        public string Flor { get; set; }

        public BuildingApd(string adress, string length, string width, string aheight, string flor)
        {
            Flor = flor;
        }

        public new void Print()
        {
            Console.WriteLine("Flors number: {0}", this.Flor);
        }

    }

}
     
