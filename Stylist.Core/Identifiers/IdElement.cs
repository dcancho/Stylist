using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stylist.Core.Identifiers
{
    internal class IdElement : CssSelector
    {
        public string LeadingSymbol { get; set; } = "#";
        public string Name { get; set; }

        public IdElement(string name)
        {
            Name = name;
        }
    }
}
