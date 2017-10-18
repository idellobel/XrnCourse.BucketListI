using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XrnCourse.BucketListI.Domain.Services;

namespace XrnCourse.BucketListI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        BucketsInMemoryService bucketListService;
        AppSettingsInMemoryService settingsService;

        public MainView()
        {
            InitializeComponent();
            settingsService = new AppSettingsInMemoryService();
            bucketListService = new BucketsInMemoryService();
        }
        private async void btnSettings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsView());
        }
        private async void btnAddBucketList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BucketsView());
        }
    }
}