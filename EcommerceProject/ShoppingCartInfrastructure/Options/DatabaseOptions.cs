using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Infrastructure.Options
{
    public class DatabaseOptions
    {
         public int MaxRetryCount { get; set; }
        public int MaxRetryDelay { get; set; }
        public int CommandTimeout { get; set; }
        public string? ConnectionString { get; set; } = string.Empty;

    }
}
