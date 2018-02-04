using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CHATINTERACTIVO
{
    public class InsertaeliminaModifica
    {

        public static int Agregar(OBTENER pOBTENER)
        {

            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into PALABRAS (FRASE,RESPUESTA) values ('{0}','{1}')",
              pOBTENER.FRASE, pOBTENER.RESPUESTA), Conn);


                retorno = comando.ExecuteNonQuery();
            }

            return retorno;
        }
        public static List<Alumno> BuscarAlumnos(String pNombre)
        {
            List<Alumno> Lista = new List<Alumno>();

            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Manco,Dios,Estado from Nombres where Manco like '%{0}%'", pNombre), conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Alumno pAlumno = new Alumno();
                    pAlumno.Manco = reader.GetString(0);
                    pAlumno.Dios = reader.GetString(1);
                    pAlumno.Estado = reader.GetString(2);

                    Lista.Add(pAlumno);

                }
                conexion.Close();
                return Lista;
            }
        }

    }
}
