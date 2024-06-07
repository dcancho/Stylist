using Stylist.Core;
using Stylist.Core.Identifiers;
using Stylist.Core.StyleProperties.Native;
using Stylist.Core.Variables.Primitive;

namespace Stylist.Tool
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stylesheet stylesheet1 = new();
			var variable1 = new ColorVariable("blue-100", 0x0F0F0F);
			stylesheet1.Variables.Add(variable1);
			var variable2 = new ColorVariable("blue-200", 0xB9B9FF);
			stylesheet1.Variables.Add(variable2);
			var variable3 = new DimensionedVariable("thick-001", 1, CssSizeUnit.px);
			stylesheet1.Variables.Add(variable3);

			// Define tokens
			stylesheet1.AddToken(new Token("container-border-color", variable1));
			stylesheet1.AddToken(new Token("container-background", variable2));
			stylesheet1.AddToken(new Token("container-border-width", variable3));

			var cardStyle = new Style();
			// Use tokens instead of variable names
			cardStyle.Add(CssProperty.backgroundColor, "container-border-color");
			cardStyle.Add(CssProperty.borderColor, "container-background");
			cardStyle.Add(CssProperty.borderWidth, "container-border-width");

			stylesheet1.AddRule(new ClassElement("card"), cardStyle);

			stylesheet1.Export();
		}
	}
}
