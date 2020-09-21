﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arm.NetcoreCompose.Data.Models
{
    public class TransactionEntity
    {
        public string Id { get; set; }

        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; }

        public DateTime TransactionDate { get; set; }

        public virtual TransactionStatusEntity Status { get; set; }

        public int StatusId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
