﻿namespace PointerMover.Models
{
    internal class Lang
    {
        public int Index { get; }
        public string Name { get; }
        public string Code { get; }

        public Lang(int index, string name, string code)
        {
            Index = index;
            Name = name;
            Code = code;
        }
    }
}
