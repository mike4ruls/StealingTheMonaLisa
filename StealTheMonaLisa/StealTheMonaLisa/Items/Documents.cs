using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StealTheMonaLisa
{
    class Documents : Item
    {
        private string itemDescrpition;
        Random rgen;

        public Documents(Texture2D itIG) : base("Top Secret\nDocuments", 100000, 100, 1.1, 2, itIG)
        {
            rgen = new Random();

        }
        public Documents(string nm, int mny, int dur, double wght, int infm, Texture2D itIg) : base(nm, mny, dur, wght, infm, itIg)
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
                        string newDescr = "The government is hiding something and i know it. So can you go and steal some documents for me please";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 2:
                    {

                        string newDescr = "This guy in the CIA has pictures of me that i'd rather not have seen to the public eye, can you get them for me?";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 3:
                    {
                        string newDescr = "I was searching through the internet and discovered that there are some documents in the pentagon that might prove bush did 9/11 and i want you to go it for me. I'll pay good money";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                case 4:
                    {
                        string newDescr = "My dad used to work for the CIA and then one day my dad went on a 'business trip' and never came back. I am calling bull shit on that. I want you to go and get some files on my dad from the pentagon. Help me find my dad, please.";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }
                default:
                    {
                        string newDescr = "This is definantely not Bernie Sanders but recently there has been some really sketchy things happening with voters votes the other day. Now most of my... i mean Bernie's supporters are the ones who couldn't vote. I want you to dig up some files on what the hell is going on.";
                        itemDescrpition = newDescr;

                        return newDescr;
                    }

            }
        }
    }
}
