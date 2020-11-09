using System;

namespace _335Labs
{
    class Student 
    {
        private string _name;
        private string _company;

        public void SetName(string newName)
        {

            newName = newName.Trim();
            var firstLetter = newName[0]
            var otherLetters = newName.Remove(0, 1);
            _name = (firstLetter.ToString().ToUpper() + otherLetters);

        }
        public void ShowName();
        { 

