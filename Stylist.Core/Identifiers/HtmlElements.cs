using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stylist.Core.Identifiers
{
    public class HtmlElement : CssSelector
    {
        public string Name { get; set; }
        public string LeadingSymbol { get; set; } = "";

        public HtmlElement(string name)
        {
            Name = name;
        }
    }
}
