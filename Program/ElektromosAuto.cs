using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            this.AkkumulatorSzint = akkumulatorSzint;
        }

        public int AkkumulatorSzint { get => akkumulatorSzint;
            set {
                if(value < 0)
                {
                    akkumulatorSzint = 0;
                }else if (value > 100)
                {
                    akkumulatorSzint = 100;
                }
                else
                {
                    akkumulatorSzint = value;
                }
            } 
        }
        public override void InformaciotAd()
        {
            Console.WriteLine($"{this.Rendszam} - {this.Kor} éves elektromos autó, {this.KilometerOra} km-rel, {akkumulatorSzint}% töltöttséggel.");
        }
        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                this.KilometerOra -= 10000;
            }
            this.AkkumulatorSzint += 20;
            Console.WriteLine("A jármű szervízelése megtörtént");
        }
    }
}
