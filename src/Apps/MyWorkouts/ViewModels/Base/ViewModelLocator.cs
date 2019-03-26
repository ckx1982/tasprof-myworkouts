using Tasprof.Apps.MyWorkouts.Interfaces;
using Tasprof.Apps.MyWorkouts.Services;
using Tasprof.Apps.MyWorkouts.Services.Navigation;
using Autofac;
using Tasprof.Apps.MyWorkouts.Services.Settings;
using Tasprof.Apps.MyWorkouts.Services.User;

namespace Tasprof.Apps.MyWorkouts.ViewModels.Base
{
    public static class ViewModelLocator
    {
        private static IContainer _container;

        static ViewModelLocator()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainViewModel>();
            builder.RegisterType<WorkoutsViewModel>();
            builder.RegisterType<AddWorkoutViewModel>();
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<RegisterViewModel>();
            builder.RegisterType<SettingsViewModel>();

            builder.RegisterType<SettingsService>().As<ISettingsService>().SingleInstance();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<WorkoutsService>().As<IWorkoutsService>().SingleInstance();
            builder.RegisterType<LocalUserService>().As<IUserService>().SingleInstance();
            _container = builder.Build();
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }

}