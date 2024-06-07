using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stylist.Core.StyleProperties.Native
{
	public enum CssProperty
	{
		backgroundColor,
		borderColor,
		borderWidth,
		borderStyle,
		borderRadius,
		boxShadow,
		color,
		display,
		fontFamily,
		fontSize,
		fontStyle,
		fontWeight,
		height,
		margin,
		padding,
		textAlign,
		textDecoration,
		width
	}

	public static class EnumExtensions
	{
		public static string ToCssProperty(this Enum value)
		{
			return string.Concat(value.ToString().Select((x, i) => i > 0 && char.IsUpper(x) ? "-" + x.ToString() : x.ToString())).ToLower();
		}
	}
}
