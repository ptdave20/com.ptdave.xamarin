using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace com.ptdave.xamarin.test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValueConverterTest : ContentPage
    {
        public ViewModels.ValueConvertModel Model
        {
            get => (ViewModels.ValueConvertModel)BindingContext;
            set => BindingContext = value;
        }
        public ValueConverterTest()
        {
            InitializeComponent();
            Model = new ViewModels.ValueConvertModel();
        }
    }
}