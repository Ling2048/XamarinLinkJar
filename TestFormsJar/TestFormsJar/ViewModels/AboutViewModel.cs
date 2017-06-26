using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestFormsJar.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            Services.IJSoup jsoup = DependencyService.Get<Services.IJSoup>();
            
            OpenWebCommand = new Command(() => {
                Task.Run(() => {
                    string sss = jsoup.Test("https://www.baidu.com/");
                });
                
                //Device.OpenUri(new Uri("https://xamarin.com/platform"));
            });
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }
    }
}
