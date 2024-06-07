namespace Stylist.Core.Variables.Primitive
{
	public interface IVariable
	{
		public string Name { get; }
		// Returns a string representation of the variable
		public string Export();
	}
}
