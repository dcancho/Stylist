using Stylist.Core.Identifiers;
using Stylist.Core.StyleProperties.Native;
using Stylist.Core.Variables.Primitive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stylist.Core
{
	public class Stylesheet
	{
		public ICollection<IVariable> Variables { get; private set;} = [];
		public ICollection<Token> Tokens { get; private set; } = [];
		public Dictionary<CssSelector, Style> Rules { get; private set; } = [];

		public void AddRule(CssSelector element, Style style)
		{
			Rules[element] = style;
		}
		public void RemoveRule(CssSelector element)
		{
			Rules.Remove(element);
		}
		public void AddToken(Token token)
		{
			if (Tokens.Any(t => t.Name == token.Name))
			{
				RemoveToken(token.Name);
			}
			Tokens.Add(token);
		}
		public void RemoveToken(string name)
		{
			Tokens.Remove(Tokens.First(t => t.Name == name));
		}

		public void Export()
		{
			StreamWriter writer = new StreamWriter("output.css");

			writer.WriteLine(":root {");			
			writer.WriteLine("/* Variables */");
			foreach (var variable in Variables)
			{
				writer.WriteLine(variable.Export());
			}
			writer.WriteLine("");
			writer.WriteLine("/* Tokens */");
			foreach (var token in Tokens)
			{
				writer.WriteLine($"--{token.Name}: var(--{token.Value.Name});");
			}
			writer.WriteLine("}");
			
			writer.WriteLine("\n/* Rules */\n");

			foreach (var rule in Rules)
			{
				writer.WriteLine($"{rule.Key.LeadingSymbol}{rule.Key.Name} {{");
				foreach (var property in rule.Value.Styles)
				{
					writer.WriteLine($"  {property.Key.ToCssProperty()}: var(--{property.Value});");
				}
				writer.WriteLine("}\n");
			}

			writer.Close();
		}
	}
}

