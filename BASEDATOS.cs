using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CHATINTERACTIVO
{
    public class BASEDATOS
    {

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source =DESKTOP-J6RAF3F;Initial Catalog =CHAT; User Id=.; Password =.");
            Conn.Open();

            return Conn;
        }
    }
}
