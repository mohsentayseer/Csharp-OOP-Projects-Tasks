using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
namespace CRUD_Operators
{
    public partial class frmCRUDOperators : Form
    {
        public frmCRUDOperators()
        {
            InitializeComponent();
            //FullAuthorsToGrideView();
        }

        //private void FullAuthorsToGrideView()
        //{
        //    //1,2,3- Connection object
        //    SqlConnection sqlConnect = new SqlConnection("Server=.;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true");

        //    //4-commands
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from Authors";

        //    //5-Remember [link commandObject to connectionObject before open()]
        //    cmd.Connection = sqlConnect;
            
        //    try
        //    {
        //        //6-open()
        //        sqlConnect.Open();

        //        //7-sqlDataReader => reference points to ResultSet
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        //8- c# object container to fill data by dataReader[DataTable]
        //        DataTable dt = new DataTable();
        //        dt.Load(dr); //dr will read automatically

        //        //9- Data binding
        //        gridAuthors.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        sqlConnect.Close();
        //    }
                
        //}

    }
}
