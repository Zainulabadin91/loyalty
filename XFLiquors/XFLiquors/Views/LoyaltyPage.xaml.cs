using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFLiquors.ViewModels;

namespace XFLiquors.Views {
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class LoyaltyPage : ContentPage {
        public LoyaltyPage() {
            InitializeComponent();
            ViewModel = new LoyaltyViewModel( Navigation );
        }
        public LoyaltyViewModel ViewModel {
            get => BindingContext as LoyaltyViewModel;
            set => BindingContext = value;
        }
    }
}