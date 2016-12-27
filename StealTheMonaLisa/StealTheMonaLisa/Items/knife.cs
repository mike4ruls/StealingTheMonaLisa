using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StealTheMonaLisa
{
    class knife : Item
    {
        private string itemDescrpition;
        Random rgen;

        public knife(Texture2D itIG) : base("A Knife", 20, 100, 3.0, 1, itIG)
        {
            rgen = new Random();
        }
        public knife(string nm, int mny, int dur, double wght, int infm, Texture2D itIg) : base(nm, mny, dur, wght, infm, itIg)
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
                        string newDescr = "That bitch named Kathy next door stole my kife. Can you go steal it back for me. If you kill her in the process i dont mind either";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 2:
                    {

                        string newDescr = "I want to become a chef but I don't have the tools to do so. Can you steal a knife for me?";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 3:
                    {
                        string newDescr = "I am in need of a knife but because of my age i can't acquire one on my own and my mom keeps the knives in the house out of my reach, that bitch. I would like you to go and steal a knife for me. Also don't ask about my age or i'll kill you.";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 4:
                    {
                        string newDescr = "In an ongoing murder case some lady stabbed her husband in the asshole 42 times. The only problem is that we have nothing to pin on her. She made it look like a break in gone wrong and the JURY ACTUALLY BELIEVES IT! I think if you find me that knife I can get her finger prints off of it and then that is one less stain on the world wiped away.";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                default:
                    {
                        string newDescr = "There is this speacial knife that can slice through anything, i mean literally anything you can think of. I want it so i can cut open this fucking watermelon that keeps fighting me everytime i try to cut it open. Go get it.";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }

            }
        }
    }
}
