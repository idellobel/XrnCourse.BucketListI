using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrnCourse.BucketListI.Domain.Models;

namespace XrnCourse.BucketListI.Domain.Services
{
    public class AppSettingsInMemoryService
    {
        private static AppSettings currentSettings = new AppSettings {
            CurrentUserId = Guid.Empty, //refers to (first) local user 
            EnableListSharing = true,
            EnableNotifications = false
        };

        public async Task<AppSettings> GetSettings()
        {
            await Task.Delay(Constants.Mocking.FakeDelay);
            return currentSettings;
        }

        public async Task SaveSettings(AppSettings settings)
        {
                await Task.Delay(Constants.Mocking.FakeDelay);
                currentSettings = settings;
        
        }

    }
}
