using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace multi_tenant_sdb.Models
{
    public class CreateProductRequest
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
    }
}