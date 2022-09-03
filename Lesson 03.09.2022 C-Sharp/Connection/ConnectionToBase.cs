using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson_03._09._2022_C_Sharp
{
    class ConnectionToBase
    {
        readonly string fileName;
        public SQLSettings defaultsetting { get; set; }

        public ConnectionToBase(string fileName = "setting.json")
        {
            if (!File.Exists(fileName))
                throw new Exception("Error: File with SQL-Base settings not found!");
            this.fileName = fileName;
        }

        public void GetSettingsFromFile() => defaultsetting = JsonSerializer.Deserialize<SQLSettings>(File.ReadAllText(fileName));

        public void GetSettings(SQLSettings setting) => defaultsetting = setting;
    }
}
