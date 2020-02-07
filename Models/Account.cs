using System;
using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public Guid MappedGnuCashAccountId { get; set; }
        public string AccountType { get; set; }
        public decimal BudgetedAmount { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal VarianceAmount { get; set; }
    }
}