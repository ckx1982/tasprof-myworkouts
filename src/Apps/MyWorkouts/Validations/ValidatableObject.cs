using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasprof.Apps.MyWorkouts.Validations
{
    public class ValidatableObject<T> : ExtendedBindableObject, IValidity
    {
        private readonly List<IValidationRule<T>> _validations;
        private List<string> _errors;
        private T _value;
        private bool _isValid;

        public List<IValidationRule<T>> Validations => _validations;

        public List<string> Errors
        {
            get
            {
                return _errors;
            }
            set
            {
                _errors = value;
                RaisePropertyChanged(() => Errors);
            }
        }

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                RaisePropertyChanged(() => Value);
            }
        }

        public bool IsValid
        {
            get
            {
                return _isValid;
            }
            set
            {
                _isValid = value;
                RaisePropertyChanged(() => IsValid);
            }

        }

        public ValidatableObject()
        {
            _isValid = true;
            _errors = new List<string>();
            _validations = new List<IValidationRule<T>>();
        }

        public bool Validate(string validationType)
        {
            Errors.Clear();
            IEnumerable<string> errors;

            if (validationType == string.Empty)
            {
                errors = _validations.Where(v => !v.Check(Value))
                                        .Select(v => v.ValidationMessage);
            }
            else
            {
                errors = _validations.Where(v => !v.Check(Value) && v.ValidationType == validationType)
                                       .Select(v => v.ValidationMessage);
            }

            Errors = errors.ToList();
            IsValid = !Errors.Any();

            return IsValid;
        }

        public static implicit operator ValidatableObject<T>(int v)
        {
            throw new NotImplementedException();
        }
    }
}
