using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw4.hw4_4
{
    public class CreditCard
    {
        public float Money { get; set; }
        public string Owner { get; set; }
        public int Cww { get; set; }

        public CreditCard(float Money, string Owner, int Cww)
        {
            this.Money = Money;
            this.Owner = Owner;
            this.Cww = Cww;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Owner: {Owner}, money: {Money}");
        }

        public static CreditCard operator +(CreditCard creditCard, float money)
        {
            creditCard.Money += money;
            return creditCard;
        }

        public static CreditCard operator -(CreditCard creditCard, float money)
        {
            creditCard.Money -= money;
            return creditCard;
        }

        public static bool operator ==(CreditCard a, CreditCard b) => a.Cww == b.Cww;

        public static bool operator !=(CreditCard a, CreditCard b) => !a.Equals(b);

        public static bool operator >(CreditCard a, CreditCard b) => a.Money > b.Money;

        public static bool operator <(CreditCard a, CreditCard b) => a.Money < b.Money;

        public override bool Equals(object obj)
        {
            CreditCard creditCard = obj as CreditCard;
            return this.Owner == creditCard.Owner && this.Cww == creditCard.Cww;
        }
    }
}
