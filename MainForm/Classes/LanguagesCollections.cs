using System.Collections.Generic;
using PointerMover.Interfaces;
using PointerMover.Models;

namespace PointerMover.Classes;

public class LanguagesCollections : ILanguagesCollections
{
    Dictionary<string, Lang[]> ILanguagesCollections.LanguagesCollections { get; } = new()
    {
        // These are hard-coded here,
        // Could be pulled from any settings source.
        {
            "en-US",
            new[]
            {
                new Lang(0, "English", "en-US"),
                new Lang(1, "French", "fr-FR"),
                new Lang(2, "Brazilian", "pt-BR"),
            }
        },
        {
            "fr-FR",
            new[]
            {
                new Lang(0, "Anglais", "en-US"),
                new Lang(1, "Français", "fr-FR"),
                new Lang(2, "Brésilien", "pt-BR"),
            }
        },
        {
            "pt-BR",
            new[]
            {
                new Lang(0, "Inglês", "en-US"),
                new Lang(1, "Francês", "fr-FR"),
                new Lang(2, "Brasileiro", "pt-BR"),
            }
        }
    };
}