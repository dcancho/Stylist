using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stylist.Core.Variables.Primitive
{
	/// <summary>
	/// Holds a color value in integer format.
	/// </summary>
	public class ColorVariable : IVariable
	{
		public string Name { get; private set; }
		public uint Value { get; private set; }

		public ColorVariable(string name, uint value)
		{
			Name = name;
			Value = value;
		}

		public ColorVariable(string name, string value)
		{
			Name = name;
			Value = uint.Parse(value.Substring(1), System.Globalization.NumberStyles.HexNumber);
		}

		public string Export()
		{
			var colorHex = string.Format("#{0:X6}", Value);
			return string.Format($"--{Name}: {colorHex};");
		}
	}
}
