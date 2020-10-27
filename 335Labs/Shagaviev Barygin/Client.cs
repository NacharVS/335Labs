using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    using System;

    public class Client
    {
        private string name;
        private Client()
        {

        }
        public Client(string n)
        {
            name = n;
        }
        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
            string re = String.Format("Client: {0}", this.name);
            return re;
        }

    }
}
