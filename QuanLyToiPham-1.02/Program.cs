using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace QuanLyToiPham_1._02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sqlite\\ProfileDatabase.db");

            string providerName = "System.Data.SQLite.EF6";

            // Initialize the connection string builder for the
            // underlying provider.
            SqlConnectionStringBuilder sqlBuilder =
            new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = directory;

            // Build the SqlConnection connection string.
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder =
            new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata = @"res://*/DBContex.csdl|res://*/DBContex.ssdl|res://*/DBContex.msl";

            connectionStringsSection.ConnectionStrings["Entities"].ConnectionString = entityBuilder.ToString();
            //"metadata=res://*/DBContext.csdl|res://*/DBContext.ssdl|res://*/DBContext.msl;provider=System.Data.SQLite.EF6;provider connection string='" + "data source=" + directory + "'";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");


            Application.Run(new MainForm());
        }
    }
}
