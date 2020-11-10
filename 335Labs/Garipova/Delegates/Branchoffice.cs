using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova.Delegates
{
    class Branchoffice
    {
        private delegate void Worker(string message);

        static void Main(string[] args)
        {
            Worker wkr;
            wkr = Generaloffice.Worker;
            wkr("Branch office");

        }
    }
}
