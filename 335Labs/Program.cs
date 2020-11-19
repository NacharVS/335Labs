using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Khabibrakhmanov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Farmer> AuthorList = new List<Farmer>();

            FarmerList.Add(new Farmer("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));
            FarmerList.Add(new Farmer("Neel Beniwal", 18, "Graphics Development with C#", false, new DateTime(2010, 2, 22)));
            FarmerList.Add(new Farmer("Praveen Kumar", 28, "Mastering WCF", true, new DateTime(2012, 01, 01)));
            FarmerList.Add(new Farmer("Mahesh Chand", 35, "Graphics Programming with GDI+", true, new DateTime(2008, 01, 20)));
            FarmerList.Add(new Farmer("Raj Kumar", 30, "Building Creative Systems", false, new DateTime(2011, 6, 3)));
           
        }
    }
}
