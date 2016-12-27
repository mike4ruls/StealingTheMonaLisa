using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StealTheMonaLisa
{
    class Dog : Item
    {
        private string itemDescrpition;
        Random rgen;

        public Dog(Texture2D itIG) : base("The\nNeighboors Dog", 350, 100, 50.0, 1, itIG)
        {
            rgen = new Random();

        }
        public Dog(string nm, int mny, int dur, double wght, int infm, Texture2D itIg) : base(nm, mny, dur, wght, infm, itIg)
        {

        }

        public override string ItemDescription
        {
            get { return itemDescrpition; }
        }

        public override string RandomDesc(int num)
        {
            switch (num)
            {
                case 1:
                    {
                        string newDescr = "Basically i hate my neighboor, so can you please steal his stupid dog for me please, it never SHUTS UP!";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 2:
                    {

                        string newDescr = "So I really want a dog but I dont have enough money, could you please steal one for me?";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 3:
                    {
                        string newDescr = "Yesterday i was sleeping and someone broke into my house and stole my dog!!! I think i know who did it too, i think it was my dad that fucking bastard. Anyways I have his address, go kill him... I mean get my dog back!!!";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 4:
                    {
                        string newDescr = "THIS RANDOM ASS DOG STRAIGHT UP ATE MY PHONE AND RAN OFF!! LIKE i'M NOT REALLY EVEN SURE IF THATS SAFE FOR A DOG TO EAT BUT FUCK THAT DOG, I NEED MY PHONE. FIND THAT FUCKER AND BRING HIM BACK TO ME";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                default:
                    {
                        string newDescr = "I have no idea where my dog is at right now. I think my dog ran away from home and i really miss him, can you get him back for me??";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }

            }
        }

    }
}
