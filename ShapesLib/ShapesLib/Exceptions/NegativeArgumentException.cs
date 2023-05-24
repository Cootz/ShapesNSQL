using System.Runtime.CompilerServices;

namespace ShapesLib.Exceptions
{
    public class NegativeArgumentException : ArgumentException
    {
        public override string Message
        {
            get => $"Parameter {memberName} cannot be negative";
        }

        private readonly string memberName;

        public NegativeArgumentException([CallerMemberName] string memberName = "") => this.memberName = memberName;
    }
}
