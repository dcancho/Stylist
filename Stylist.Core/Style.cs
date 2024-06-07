using System.Text.RegularExpressions;
using Stylist.Core.StyleProperties.Native;

namespace Stylist.Core
{
    public class Style
    {
        public Dictionary<CssProperty, string> Styles { get; private set; } = [];

        public void Add(CssProperty property, string tokenName)
        {
            Styles[property] = tokenName;
        }

        public void Remove(CssProperty property)
        {
               Styles.Remove(property);
        }
		
		private static string NativePropertyName(string name)
		{
			return Regex.Replace(name, "([A-Z])", "-$1").ToLower();
		}
    }
}
