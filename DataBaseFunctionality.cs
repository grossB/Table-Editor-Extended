using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Goat_s_KO_Table_Editor
{
    public static class DataBaseFunctionality
    {
        public static DataSet DataSetItem{ get; set;}

        public static DataTable Sql()
        {
            DataSetItem = new DataSet();
            string connetionString;
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommandBuilder cmdBuilder;
            DataSet changes;
            string Sql;
            Int32 i;

            connetionString = @"Data Source=DESKTOP-DU3UCSC\KN_ONLINE; Initial Catalog = KN_Online; Integrated Security = True";


            connection = new SqlConnection(connetionString);
            Sql = "select top 10 * from Item";
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(Sql, connection);
                adapter.SelectCommand = new SqlCommand(Sql);
                adapter.SelectCommand.Connection = connection;
                adapter.Fill(DataSetItem, "Item");
                connection.Close();
                return DataSetItem.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
