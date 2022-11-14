using KattaCalculater.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KattaCalculater.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.BindingContext = GetTransactionDetails();
        }

        private TransactionDetailViewModel GetTransactionDetails()
        {
            var transactionDetail = new TransactionDetailViewModel();

            transactionDetail.Transactions = GetTransactions();

            return transactionDetail;
        }

        private IEnumerable<KattaCalculater.Models.Transaction> GetTransactions()
        {
            var transactions = new List<KattaCalculater.Models.Transaction>();

            transactions.Add(new KattaCalculater.Models.Transaction() { DateIn = DateTime.Now, DateOut = null, KutteCount = 10, DesignId = 10, PartyId = 10, Saada = 7, Tode = 2 });
            transactions.Add(new KattaCalculater.Models.Transaction() { DateIn = DateTime.Now, DateOut = null, KutteCount = 10, DesignId = 10, PartyId = 10, Saada = 7, Tode = 2 });
            transactions.Add(new KattaCalculater.Models.Transaction() { DateIn = DateTime.Now, DateOut = null, KutteCount = 10, DesignId = 10, PartyId = 10, Saada = 7, Tode = 2 });

            return transactions;
        }
    }
}