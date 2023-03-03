using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerMoverNETFramework.Classes
{
    internal class Language
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Language(int index,string name, string code)
        {
            Index = index;
            Name = name;
            Code = code;
        }
    }
}
