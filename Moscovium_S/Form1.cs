using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;
namespace Moscovium_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            blazorWebView1.HostPage = "wwwroot\\index.html";
           

            services.AddSingleton<ThemeService>();

            var serviceProvider = services.BuildServiceProvider();

        
            blazorWebView1.Services = serviceProvider;
           
            blazorWebView1.RootComponents.Add<App>("#app");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
