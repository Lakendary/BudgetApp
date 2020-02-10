using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models
{
    public class Budget
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public int NumberOfWeeks { get; set; }
        public List<Account> Accounts { get; set; }
    }
}