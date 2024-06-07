using Stylist.Core.Variables.Primitive;

namespace Stylist.Core {
	public class Token {
		public string Name { get; private set; }
		public IVariable Value { get; private set; }
		public Type TokenType { get; private set; }

		public Token(string name, IVariable value) {
			Name = name;
			Value = value;
			TokenType = value.GetType();
		}
	}
}