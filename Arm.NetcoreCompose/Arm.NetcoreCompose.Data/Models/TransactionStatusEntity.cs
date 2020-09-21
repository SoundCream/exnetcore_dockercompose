using System;
using System.Collections.Generic;
using System.Text;

namespace Arm.NetcoreCompose.Data.Models
{
    public class TransactionStatusEntity
    {
        public int Id { get; set; }

        public string StatusName { get; set; }

        public string StatusCode { get; set; }

        public bool IsActive { get; set; }
    }
}
