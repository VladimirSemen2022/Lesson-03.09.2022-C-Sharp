using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03._09._2022_C_Sharp
{
    class SQLSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public bool Trusted_Connection { get; set; }

        public SQLSettings(string Server, string Database, bool Trusted_Connection)
        {
            this.Server = Server;
            this.Database = Database;
            this.Trusted_Connection = Trusted_Connection;
        }

        public override string ToString()
        {
            return $"Server={this.Server};Database={this.Database};Trusted_Connection={this.Trusted_Connection}";
        }
    }
}
