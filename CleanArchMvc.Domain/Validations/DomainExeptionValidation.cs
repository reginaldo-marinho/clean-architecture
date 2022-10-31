public class DomainExeptionValidation: System.Exception
{
    public DomainExeptionValidation(string message) : base(message) { }
    public DomainExeptionValidation(string message, System.Exception inner) : base(message, inner) { }

    public static void When (bool hasError, string error){
        if (hasError)
            throw new DomainExeptionValidation(error);
    }
}
