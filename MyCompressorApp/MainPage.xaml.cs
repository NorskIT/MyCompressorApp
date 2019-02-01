using System;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyCompressorApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(600, 300);
			ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

		//Removes focus from TextBox.
        private void RemoveFocus(object sender, RoutedEventArgs e)
        {
	        addCompressFileButton.Focus(FocusState.Programmatic);
        }

		private async Task AddCompressFileButton_Click(object sender, RoutedEventArgs e)
		{
			FileOpenPicker picker = new Windows.Storage.Pickers.FileOpenPicker();
			picker.ViewMode = PickerViewMode.Thumbnail;
			picker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
			picker.FileTypeFilter.Add("*");

			StorageFolder storage = Windows.Storage.ApplicationData.Current.LocalFolder;
			StorageFile fileReader = await picker.PickSingleFileAsync();
		}

		private void AddCompressFileToPath_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
