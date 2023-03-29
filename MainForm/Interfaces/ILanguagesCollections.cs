using System.Collections.Generic;
using PointerMover.Models;

namespace PointerMover.Interfaces;

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