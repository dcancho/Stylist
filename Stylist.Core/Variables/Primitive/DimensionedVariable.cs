namespace Stylist.Core.Variables.Primitive
{
	public class DimensionedVariable : IVariable
	{
		public string Name { get; private set; }
		public float Value { get; private set; }
		public CssSizeUnit Unit { get; private set; }

		public DimensionedVariable(string name, float value, CssSizeUnit unit)
		{
			Name = name;
			Value = value;
			Unit = unit;
		}

		public string Export()
		{
			string unitSymbol = Unit switch
			{
				CssSizeUnit.px => "px",
				CssSizeUnit.em => "em",
				CssSizeUnit.rem => "rem",
				CssSizeUnit.percent => "%",
				_ => "",
			};
			return $"--{Name}: {Value}{unitSymbol};";
		}
	}

	public enum CssSizeUnit
	{
		px,
		em,
		rem,
		percent
	}
}
