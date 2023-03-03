using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Rank
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public Person(int r, string n, string g)
        {
            Rank = r;
            Name = n;
            Gender = g;
        }
    }
}
