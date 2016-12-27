using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StealTheMonaLisa
{
    class TypeWriter
    {
        int frames;
        int letter;
        int outOfBounds;
        int margins;
        bool flashing;
        bool end;
        string bar;
        string outtext;
        string word;
        public TypeWriter(int mrg)
        {
            frames = 5;
            letter = 0;
            outOfBounds = 0;
            margins = mrg;
            flashing = true;
            end = false;
            bar = "|";
            outtext = "";
            word = "";
        }
        public string Type(string intext)
        {
            frames -= 1;
            if (frames == 0)
            {
                if (letter < intext.Length)
                {
                    //outtext = outtext + intext[letter];
                    word = word + intext[letter];

                    if (intext[letter] == ' ')
                    {
                        outtext = outtext + word;
                        word = "";
                    }
                    outOfBounds += 1;

                    if (outOfBounds > margins)
                    {
                        outtext = outtext + "\n";
                        
                        outOfBounds = 0;
                        outOfBounds += word.Count() - 1;
                    }
                    frames = 5;
                    letter += 1;
                }
                else
                {
                    frames = 50;
                    end = true;
                }
            }

            if (end)
            {
                if (frames == 1)
                {
                    if (flashing)
                    {
                        bar = "|";
                        frames = 50;
                        flashing = false;
                    }
                    else
                    {
                        bar = "";
                        frames = 50;
                        flashing = true;
                    }

                }
            }
            return outtext + word + bar;
        }
        public bool Done()
        {
            return end;
        }
        public void Reset()
        {
            outOfBounds = 0;
            word = "";

            letter = 0;
            bar = "|";
            end = false;
            outtext = "";
        }
    }
}
