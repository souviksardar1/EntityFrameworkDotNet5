using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDotNet5.Models
{
    public class AppSettingsModel
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public FurnitureApi furnitureApi { get; set; }
    }

    public class ConnectionStrings
    {
        public string FurnitureContext { get; set; }
    }

    public class FurnitureApi
    {
        public string Address { get; set; }
        public string Environment { get; set; }
    }
}
