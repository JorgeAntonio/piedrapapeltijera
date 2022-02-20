using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiedraPapelTijera.Components
{
    public class Choices
    {
        private readonly Dictionary<int, String> choices = new Dictionary<int, String>{
            {0, "✊"},
            {1, "🤚"},
            {2, "✌️"}
        };

        public string this[int choiceKey] => choices[choiceKey]; 
    }
}