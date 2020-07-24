using System;
using System.Collections.Generic;

namespace AngBand.Core
{
    public class Addition
    {
        public class Somme
        {
            public Somme(IEnumerable<int> elements)
            {
                Resultat = 0;
                foreach (var element in elements) Resultat += element;
            }

            public long Resultat { get; }
        }
    }
}
    