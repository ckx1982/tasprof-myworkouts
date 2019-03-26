namespace Tasprof.Apps.MyWorkouts.Validations
{
    public interface IValidationRule<T>
    {

        string ValidationType { get; set; }
        string ValidationMessage { get; set; }
        bool Check(T value);
    }
}
