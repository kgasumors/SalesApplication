using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Model
{
    public class SupplierModel
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string? SupplierName { get; set; }

        public string? TelephoneNumber { get; set; }
    }
}
