using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_acceso;
using System.Data;

namespace Capa_de_negocio
{
    public class E_prod
    {
        public float litros { get; set; }
        public DateTime fech_reg { get; set; }
        public int cod_vaca { get; set; }

        Classconexion ccont = new Classconexion();

        public String registrar_prod() {
            String reporte="";
            List<Classparametros> lpms = new List<Classparametros>();
            try
            {
                //Parametros de entrada
                lpms.Add(new Classparametros("@Litro", litros));
                lpms.Add(new Classparametros("@Fech_prod", fech_reg));
                lpms.Add(new Classparametros("@Cod_vaca", cod_vaca));

                //Paramentros de salida
                lpms.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                ccont.Exec_sp("reg_prod", lpms);
                reporte = lpms[3].Valor.ToString();
                
            }
            catch (Exception)
            {

                throw;
            }


            return reporte;
        }

        public DataTable listar_prod() {
            return ccont.Listar_datos("list_prod", null);
        }
    }
}
