using System;
using System.Collections.Generic;
using System.Text;

namespace Tasprof.Apps.MyWorkouts.Services.Settings
{
    public interface ISettingsService
    {
        string AuthAccessToken { get; set; }
    }
}
