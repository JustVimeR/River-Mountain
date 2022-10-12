using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River_Interface
{
    interface GeoObjecct
    {
        int CooX { get; set; }
        int CooY { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        void ShowInfo();
    }
    class River : GeoObjecct
    {
        public int CooX { get; set; }
        public int CooY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Speed { get; set; }
        public double Length { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Назва {0}", Name);
            Console.WriteLine("Координати: {0}, {1}", CooX, CooY);
            Console.WriteLine("Опис: {0}", Description);
            Console.WriteLine("Швидкість: {0}", Speed);
            Console.WriteLine("Довжина: {0}\n", Length);
        }
    }
    class Mountain : GeoObjecct
    {
        public int CooX { get; set; }
        public int CooY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HighestPoint { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Назва {0}", Name);
            Console.WriteLine("Координати: {0}, {1}", CooX, CooY);
            Console.WriteLine("Опис: {0}", Description);
            Console.WriteLine("Найвища точка: {0}", HighestPoint);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            GeoObjecct dnipro = new River()
            {
                CooX = 0,
                CooY = 0,
                Name = "Dnipro",
                Description = "четверта за довжиною ы третя за площею річка в світі",
                Speed = 1.2,
                Length = 2201
            };
            GeoObjecct Goverla = new Mountain()
            {
                CooX = 1,
                CooY = 1,
                Name = "Goverla",
                Description = "найвища вершина Українських Карпат і найвища точка України",
                HighestPoint = 2061
            };
            dnipro.ShowInfo();
            Goverla.ShowInfo();
            Console.ReadKey();
        }
    }
}
