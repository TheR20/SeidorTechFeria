using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHATINTERACTIVO
{
    public class OBTENER
    {

        
        public String Frase { get; set; }

        public String Respuesta{ get; set; }

   



        public OBTENER() { }

        public OBTENER(String pFRASE, String pRespuesta )
        {
            this.Frase = pFRASE;
            this.Respuesta = pRespuesta;

 

        }
    }
}
