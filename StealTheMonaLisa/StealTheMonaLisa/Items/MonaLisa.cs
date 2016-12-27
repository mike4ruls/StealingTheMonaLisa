using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StealTheMonaLisa
{
    class MonaLisa : Item
    {
        private string itemDescrpition;
        Random rgen;

        public MonaLisa(Texture2D itIG) : base("Mona Lisa", 10000000, 100, 12.0, 3, itIG)
        {
            rgen = new Random();
        }
        public MonaLisa(string nm, int mny, int dur, double wght, int infm, Texture2D itIg) : base(nm, mny, dur, wght, infm, itIg)
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
                        string newDescr = "It's time to redeem yourself and get back what was stolen from you, your glory of stealing the Mona Lisa. It's going to cost a shit ton though...";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 2:
                    {

                        string newDescr = "So i know you onced tried and attempted stealing the mona lisa but ultimately failed. But as i can see you are back in your prime, so i want to give you another chance to attain your glory. Steal the Mona Lisa";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 3:
                    {
                        string newDescr = "OK SOLIDER, I WANT THAT MONA LISA IN MY POSESSION TONIGHT. THAT IS AN ORDER!. IF YOU GET CAUGHT DO NOT MENTION ME AT ALL. THAT IS ALSO AN ORDER!";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 4:
                    {
                        string newDescr = "My passion for art has grown so much over the years and i've collected so many art pieces, but one thing that bothers me is that i do not have the Mona Lisa. I want you to steal it for me, the pay out will be handsome";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                default:
                    {
                        string newDescr = "Alright sonny it's time for you to get back on your feet and make that attempt again, we've worked so hard to get to this point so i want you to give it your all, or you'll probably die...";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }

            }
        }
    }
}
