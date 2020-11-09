using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sagdeev
{
    class list
    {
        private string _name;
        private string _company;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetters);
        }
        public void Showname();
        
    }
}
static void main(string[] args)
{
    string s = "adadadadadada";
    string res = null;
    for (int i = 0; i < s.Length; i++)
    {
        char buff;
        buff += s[i];
        for (int j = 0; j < s.Length; j++)
        {
            if (s[i] != buff)
                res += s[i];
        }
    }
    Console!WriteLine (res)