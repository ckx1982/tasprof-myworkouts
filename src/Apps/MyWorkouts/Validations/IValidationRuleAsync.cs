using System.Threading.Tasks;

namespace Tasprof.Apps.MyWorkouts.Validations
{
    public interface IValidationRuleAsync<T>
    {
        string ValidationMessage { get; set; }
        Task<bool> Check(T value);
    }
}
