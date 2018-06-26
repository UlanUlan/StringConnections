using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DB.Pages
{
    /// <summary>
    /// Interaction logic for OD.xaml
    /// </summary>
    public partial class OD : Page
    {
        public OD()
        {
            InitializeComponent();
            OdbcConnection con;
            try
            {
                using (con = new OdbcConnection(MainWindow.s))
                {
                    con.Open();
                    Label ConnectionString = new Label();
                    ConnectionString.Content = con.ConnectionString;
                    Label Database = new Label();
                    Database.Content = con.Database;
                    Label DataSource = new Label();
                    DataSource.Content = con.DataSource;
                    Label ServerVersion = new Label();
                    ServerVersion.Content = con.ServerVersion;
                    // Label WorkstationId = new Label();
                    //WorkstationId.Content = con.WorkstationId;
                    Pravo.Children.Add(ConnectionString);
                    Pravo.Children.Add(Database);
                    Pravo.Children.Add(DataSource);
                    Pravo.Children.Add(ServerVersion);
                    // Pravo.Children.Add(WorkstationId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
