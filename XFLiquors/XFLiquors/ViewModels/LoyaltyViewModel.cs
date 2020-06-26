using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFLiquors.ViewModel;
using XFLiquors.Views;

namespace XFLiquors.ViewModels {
    public class LoyaltyViewModel : BaseViewModel {


        public Command ProceedToPaymentCommand { get; }
        public Command EnableNotificationCommand { get; }

        private string itemTotal;
        public string ItemTotal {
            get => itemTotal;
            set => SetProperty( ref itemTotal, value );
        }
        private string delivereyFee;
        public string DelivereyFee {
            get => delivereyFee;
            set => SetProperty( ref delivereyFee, value );
        }

        private string delivereyCharges;
        public string DelivereyCharges {
            get => delivereyCharges;
            set => SetProperty( ref delivereyCharges, value );
        }
        private string texAndCharges;
        public string TexAndCharges {
            get => texAndCharges;
            set => SetProperty( ref texAndCharges, value );
        }
        private string topay;
        public string Topay {
            get => topay;
            set => SetProperty( ref topay, value );
        }

        private bool isCardsEnabled;
        public bool IsCardsEnabled { 
            get => isCardsEnabled;
            set => SetProperty( ref isCardsEnabled, value );
        }

        private bool ispayPalEnabled;
        public bool IspayPalEnabled { 
            get => ispayPalEnabled;
            set => SetProperty( ref ispayPalEnabled, value );
        }

        public LoyaltyViewModel(INavigation navigation) {
            Navigation = navigation;
            ProceedToPaymentCommand = new Command( async () => await OnProceedToPayment() );
            EnableNotificationCommand = new Command( async () => await OnEnableNotificationCommand() );
            Title = "Payments";
            LoadPage();
        }

        private void LoadPage() {
            ItemTotal = "$13.03";
            DelivereyFee = "$10.00";
            TexAndCharges = "$10.00";
            DelivereyCharges = "$0.50";
            Topay = "$13.00";
        }

        private async Task OnEnableNotificationCommand() {
            await DisplayAlert( "ProceedToPayment", "EnableNotification called", "Ok" );
        }

        private async Task OnProceedToPayment() {
            await DisplayAlert( "ProceedToPayment", "ProceedToPayment called", "Ok" );
        }

    }
}
