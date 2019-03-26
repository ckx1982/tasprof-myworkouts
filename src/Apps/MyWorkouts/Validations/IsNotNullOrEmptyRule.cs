namespace Tasprof.Apps.MyWorkouts.Validations
{
    public class IsNotNullOrEmptyRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }
        public string ValidationType { get; set; }

        public bool Check(T value)
        {
            if (value ==null)
            {
                return false;
            }

            var str = value as string;
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}
