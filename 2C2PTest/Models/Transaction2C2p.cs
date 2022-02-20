using System;
using System.Collections.Generic;

namespace _2C2PTest.Models
{
    public partial class Transaction2C2p
    {
        public string TransactionId { get; set; } = null!;
        public decimal? Amount { get; set; }
        public string? Currency { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Status { get; set; }
        public string? FileType { get; set; }
        public string? Payment { get; set; }
        public string? OutputStatus { get; set; }
    }
}
