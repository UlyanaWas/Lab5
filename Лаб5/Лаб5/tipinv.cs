using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб5
{
    class TipInv
    {
        public string NameTip { get; set; }
        public string OpisanieTip { get; set; }
        public int IDTip { get; set; }



        public TipInv(string NameTip, string OpisanieTip, int IDTip)
        {
            this.NameTip = NameTip;
            this.OpisanieTip = OpisanieTip;
            this.IDTip = IDTip;
        }

        public void GetInfo()
        {
            Console.WriteLine("\n      Код типа: {0}\n      Название: {1}\n      Описание: {2}\n", IDTip, NameTip, OpisanieTip);
        }
    }
}
