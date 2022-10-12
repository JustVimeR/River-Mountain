using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River
{
    abstract class GeoObject
    {
        public int CooX;
        public int CooY;
        public string Name;
        public string Description;
        public virtual void ShowInfo()
        {
            Console.WriteLine("Назва: {0}", Name);
            Console.WriteLine("Координати: {0},{1}", CooX, CooY);
            Console.WriteLine("Опис: {0}", Description);
        }
    }
    class River : GeoObject
    {
        public double Speed;
        public double Lenght;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Швидкість: {0} м/с", Speed);
            Console.WriteLine("Швидкість: {0} км\n", Lenght);
        }
    }
    class Mountain : GeoObject
    {
        public int HighestPoint;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Найвища точка: {0}\n", HighestPoint);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            GeoObject dnipro = new River()
            {
                CooX = 0,
                CooY = 0,
                Name = "Dnipro",
                Description = "четверта за довжиною ы третя за площею річка в світі",
                Speed = 1.2,
                Lenght = 2201
            };
            GeoObject Goverla = new Mountain()
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
