namespace Stylist.Core.Variables.Primitive
{
	/// <summary>
	/// Token that holds a numeric value within the real number set.
	/// </summary>
	public class NumericVariable : IVariable
	{
		public string Name { get; private set; }
		public float Value { get; private set; }
		public NumericVariable(string name, float value)
		{
			Name = name;
			Value = value;
		}

		public string Export()
		{
			return string.Format($"--{Name}: {Value};");
		}
	}
}
