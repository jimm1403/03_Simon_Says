using System;
using System.Linq;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string simonEcho)
        {
            return simonEcho.ToLower();
        }

        internal string Shout(string simonShout)
        {
            return simonShout.ToUpper();
        }

        internal string Repeat(string simonRepeat, int _repeatTimes) //Det er her den er gal???
        {
            _repeatTimes = default(int);
            if (_repeatTimes <= 2)
            {
                return simonRepeat + " " + simonRepeat;
            }
            else
                string.Concat(Enumerable.Repeat(simonRepeat, _repeatTimes));
                return simonRepeat;
            
        }

        //internal string StartOfWord(string _simonSays, int _charCount)
        //{
        //    return _simonSays.Substring(0, _charCount);
        //}
    }
}