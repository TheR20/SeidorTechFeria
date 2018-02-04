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
            using (SqlConnection Conn = BASEDATOS.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into PALABRAS (FRASE,RESPUESTA) values ('{0}','{1}')",
              pOBTENER.Frase, pOBTENER.Respuesta), Conn);


                retorno = comando.ExecuteNonQuery();
            }

            return retorno;
        }
        public static List<OBTENER> BuscarAlumnos(String pNombre)
        {
            List<OBTENER> Lista = new List<OBTENER>();


           
            using (SqlConnection conexion = BASEDATOS.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Frase,Respuesta from PALABRAS where Frase like '%{0}%'", pNombre), conexion);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    OBTENER POBTENER = new OBTENER();

                    POBTENER.Frase = reader.GetString(0);
                    POBTENER.Respuesta = reader.GetString(1);

                    
                    
                    Lista.Add(POBTENER);

                }
                conexion.Close();
                return Lista;
            }
            
        }


        

    }
}
