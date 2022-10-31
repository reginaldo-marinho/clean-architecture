public class DomainExeptionValidation: System.Exception
{
    public DomainExeptionValidation() { }
    public DomainExeptionValidation(string message) : base(message) { }
    public DomainExeptionValidation(string message, System.Exception inner) : base(message, inner) { }
    protected DomainExeptionValidation(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
