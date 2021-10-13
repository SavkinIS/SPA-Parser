using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SPAParser.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SPAParser.Server.DataFolder.ContextFolder
{
    public class DataContextSQL : DbContext
    {
        public DbSet<Product> Products { get; set; }


        public DataContextSQL() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Directory.GetCurrentDirectory() + @"\ConnectionString.json";
            string connectionstring = File.ReadAllText(path);
            Root root = JsonConvert.DeserializeObject<Root>(connectionstring);
            ///Изменить строку подключения
            optionsBuilder.UseSqlServer(
                root.ConnectionString
                );
        }
    }
}
