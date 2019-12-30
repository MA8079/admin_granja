using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_acceso;
using System.Data;

namespace Capa_de_negocio
{
    public class E_vacas
    {
        public String raza { get; set; }
        public String l_origen { get; set; }
        public DateTime fech_nac { get; set; }
        public Byte[] foto_vaca { get; set; }

        Classconexion Cnt = new Classconexion();


        //metodos
        public String Registrar_entrada() {
            String report = "";
            List<Classparametros> lpms = new List<Classparametros>();
            try
            {
                //parametros de entrada
                lpms.Add(new Classparametros("@Raza", raza));
                lpms.Add(new Classparametros("@Procedencia", l_origen));
                lpms.Add(new Classparametros("@Fech_nac", fech_nac));
                lpms.Add(new Classparametros("@Foto", foto_vaca));
                //parametros de salida
                lpms.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                

                Cnt.Exec_sp("reg_vaca",lpms);
                report = lpms[4].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return report;
        }

        //Listar vacas
        public DataTable Listar_datos() {
            return Cnt.Listar_datos("list_vacas", null);
        }
    }
}
