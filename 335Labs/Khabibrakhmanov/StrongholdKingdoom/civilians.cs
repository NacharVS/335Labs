using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Khabibrakhmanov.StrongholdKingdoom
{
    class civilians
    {
        private string name;
        private short age;
        private string title;
        private bool mvp;
        private DateTime pubdate;

        public void Farmer(string name, short age, string title, bool mvp, DateTime pubdate)
        {
            this.name = name;
            this.age = age;
            this.title = title;
            this.mvp = mvp;
            this.pubdate = pubdate;
            return;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public short Age
        {
            get { return age; }
            set { age = value; }
        }
        public string BookTitle
        {
            get { return title; }
            set { title = value; }
        }
        public bool IsMVP
        {
            get { return mvp; }
            set { mvp = value; }
        }
        public DateTime PublishedDate
        {
            get { return pubdate; }
            set { pubdate = value; }
        }
               
            public (string author in FarmerLIst)
            {
                Console.WriteLine("Author: {0},{1},{2},{3},{4}", author.Name, author.Age, author.BookTitle, author.IsMVP, author.PublishedDate);
            }
    }
}


