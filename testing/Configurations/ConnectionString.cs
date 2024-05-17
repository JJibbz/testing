using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetLib.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\COCOJUMBO\SQLEXPRESS01;Database=testing;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
    }
}
