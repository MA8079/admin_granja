using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_acceso;
using System.Data;

namespace Capa_de_negocio
{
    public class E_toros
    {
        public String raza { get; set; }
        public String l_origen { get; set; }
        public DateTime fech_nac { get; set; }
        public Byte[] foto_toro { get; set; }

        Classconexion Cnt = new Classconexion();

        public String Registrar_entrada()
        {
            String report = "";
            List<Classparametros> lst = new List<Classparametros>();
            try
            {
                //Parametros de entrada
                lst.Add(new Classparametros("@Raza", raza));
                lst.Add(new Classparametros("@Procedencia", l_origen));
                lst.Add(new Classparametros("@Fech_nac", fech_nac));
                lst.Add(new Classparametros("@Foto", foto_toro));
                //Parametros de salida
                lst.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));

                Cnt.Exec_sp("reg_toro",lst);
                report = lst[4].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return report;

        }

        public DataTable Listar_toros() {
            return Cnt.Listar_datos("list_toros", null);
        }
    }
}
