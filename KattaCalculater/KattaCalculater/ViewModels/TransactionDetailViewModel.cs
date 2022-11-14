using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace KattaCalculater.ViewModels
{
    public class TransactionDetailViewModel
    {
        public IEnumerable<KattaCalculater.Models.Transaction> Transactions { get; set; }
    }
}
