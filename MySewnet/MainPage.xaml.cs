using static System.Net.Mime.MediaTypeNames;

namespace MySewnet
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnMauiBtnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Launch btn clicked");
            try
            {
                await Launcher.Default.OpenAsync("sc://LottiePage");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Cannot launch medium flutter app {ex.Message}");
            }
        }

        private async void OnFlutterBtnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Launch btn clicked");
            try
            {
                await Launcher.Default.OpenAsync("news://test.gadgeon.com");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Cannot launch medium flutter app {ex.Message}");
            }
        }

        private async void OnShareBtnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("OnShareBtnClicked");
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.abc");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, world!");
                    writer.WriteLine("This is a sample text written to the file.");
                }
                //var result = await FilePicker.Default.PickAsync(PickOptions.Images);
                //if (result != null)
                //{
                //    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                //        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                //    {
                //        using var stream = await result.OpenReadAsync();
                //        var image = ImageSource.FromStream(() => stream);
                //    }
                await Share.Default.RequestAsync(new ShareFileRequest
                    {
                        Title = "Share text file",
                        File = new ShareFile(filePath)
                    });
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can't share files");
            }
            
        }
    }

}
