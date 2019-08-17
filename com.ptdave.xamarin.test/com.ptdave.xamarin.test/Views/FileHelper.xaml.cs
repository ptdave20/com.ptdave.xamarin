using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using com.ptdave.xamarin.Abstraction;

namespace com.ptdave.xamarin.test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileHelper : ContentPage
    {
        public ViewModels.FileHelperModel Model
        {
            get => (ViewModels.FileHelperModel)BindingContext;
            set => BindingContext = value;
        }
        public FileHelper()
        {
            InitializeComponent();
            Model = new ViewModels.FileHelperModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var fileService = DependencyService.Get<IFileHelper>();
            Model.Path = fileService.DatabaseFile("data.db");
        }
    }
}