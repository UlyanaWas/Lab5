using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб5
{
    class Program
    {
        static void Main(string[] args)
        {
            TipInv Tip1 = new TipInv("Тренажеры", "Инвентарь для тренировок", 1);
            TipInv Tip2 = new TipInv("Компьютеры", "Инвентарь для администрирования", 2);
            TipInv Tip3 = new TipInv("Мебель", "Прочий инвентарь", 3);
            Inventar Inv1 = new Inventar("Беговая дорожка", 1, 15000.50, DateTime.Today, Tip1);
            Inventar Inv2 = new Inventar("Скамья", 2, 10000.00, DateTime.Today, Tip1);
            Inventar Inv3 = new InvArenda("Ноутбук бухгалтера", 3, 20000.00, DateTime.Today, Tip2, DateTime.Today, "Иван Иванов");
            Inventar Inv4 = new Inventar("Зеркало", 4, 15000.00, DateTime.Today, Tip3);
            Inventar Inv5 = new InvArenda("Швабра", 5, 500.17, DateTime.Today, Tip3, DateTime.Today, "Галина");

            List<Inventar> lstInventar = new List<Inventar>();
            lstInventar.Add(Inv1);
            lstInventar.Add(Inv2);
            lstInventar.Add(Inv3);
            lstInventar.Add(Inv4);
            lstInventar.Add(Inv5);

            int idNum = 0;
            Console.Write("Введите номер инвентаря ");
            idNum = Convert.ToInt32(Console.ReadLine());

            Inventar selInv = lstInventar.SingleOrDefault(i1 => i1.IDinv == idNum);
            if (selInv == null)
                Console.WriteLine("Не найдено");
            else
            {
                selInv.GetInfo();
            }



            Console.ReadLine();
        }

    }
}
