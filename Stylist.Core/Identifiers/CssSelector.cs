using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stylist.Core.Identifiers
{
    public interface CssSelector
    {
        public string LeadingSymbol { get; set; }
        public string Name { get; set; }
    }
}
