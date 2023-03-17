﻿using MainForm.Classes;
using System.Collections.Generic;

namespace MainForm.Interfaces;

public interface ILanguagesCollections
{
    //
    // Members
    //
    internal Dictionary<string, Lang[]> LanguagesCollections { get; }

    //
    // Methods
    //
}