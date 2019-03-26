using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tasprof.Apps.MyWorkouts.Models.User;
using Tasprof.Apps.MyWorkouts.Services.User;
using Tasprof.Apps.MyWorkouts.Validations;
using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using Xamarin.Forms;

namespace Tasprof.Apps.MyWorkouts.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        private IUserService _userService;
        private ValidatableObject<string> _username;
        private ValidatableObject<string> _password;
        private bool _isValid;

        public LoginViewModel(IUserService userService)
        {
            _userService = userService;
            _username = new ValidatableObject<string>();
            _password = new ValidatableObject<string>();
            AddValidations();
        }

        #region Commands

        public ICommand SignInCommand => new Command(async() => await SignInAsync());
        public ICommand RegisterCommand => new Command(async () => await RegisterAsync());

        #endregion

        #region Public Properties 

        public ValidatableObject<string> Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged(() => Username);
            }
        }

        public ValidatableObject<string> Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
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

        #endregion

        #region Private Methods

        private void AddValidations()
        {
            _username.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationType = "I", ValidationMessage = "A username is required." });
            _username.Validations.Add(new UserExistsRule<string> { ValidationType = "D",  ValidationMessage = "A user already exists." });
            _password.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationType ="I", ValidationMessage = "A password is required." });
        }

        private bool Validate(string validationType)
        {
            bool isValidUser = ValidateUserName(validationType);
            bool isValidPassword = ValidatePassword();

            return isValidUser && isValidPassword;
        }

        private bool ValidateUserName(string validationType)
        {
            return _username.Validate(validationType);
        }

        private bool ValidatePassword()
        {
            return _password.Validate(string.Empty);

        }

        private async Task SignInAsync()
        {

            IsBusy = true;
            IsValid = true;

            bool isValid = Validate("I");

            if (!isValid)
            {
                IsValid = false;
            }
            else
            {
                // validate input

                // if valid

                // check authentication

                // navigate to Main View

                await NavigationService.NavigateToAsync<MainViewModel>();
            }


            IsBusy = false;
        }

        private async Task RegisterAsync()
        {
            IsBusy = true;
            IsValid = true;

            bool isValid = Validate(string.Empty);

            if (!isValid)
            {
                IsValid = false;
            }
            else
            {
                var userInfo = await _userService.AddUserAsync(Username.Value, Password.Value);

                // navigate to Main View
                await NavigationService.NavigateToAsync<MainViewModel>();
            }

            IsBusy = false;
        }


        #endregion

    }
}