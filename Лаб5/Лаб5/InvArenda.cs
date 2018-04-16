using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб5
{
    class InvArenda : Inventar
    {
        DateTime DateArenda { get; set; }
        string Vladelets { get; set; }
        public InvArenda(string NameInv, int IDinv, double CostInv, DateTime DateInv, TipInv Tip, DateTime DateArenda, string Vladelets)
            : base(NameInv, IDinv, CostInv, DateInv, Tip)
        {
            this.DateArenda = DateArenda;
            this.Vladelets = Vladelets;
        }

        public void GetInfoArenda()
        {
            Console.Write("Этот инвентарь в аренде\n    Дата возврата арендованного инвентаря: {0}\n    Владелец: {1}\n", DateArenda, Vladelets);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            GetInfoArenda();
        }
        
    }
}
