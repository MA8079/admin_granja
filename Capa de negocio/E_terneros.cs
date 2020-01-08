using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_acceso;
using System.Data;


namespace Capa_de_negocio
{
     public class E_terneros
    {
        public int cod_padre { get; set; }
        public int cod_madre { get; set; }
        public String raza { get; set; }
        public DateTime fech_nac { get; set; }
        public String tip_procreacion { get; set; }
        public Byte[] foto_ternero { get; set; }


        //Agregar referencia a la clase de conexion
        Classconexion Cnt = new Classconexion();

        public String Registrar_entrada() {
            String report = "";
            List<Classparametros> lst = new List<Classparametros>();
            try
            {
                lst.Add(new Classparametros("@Cod_toro", cod_padre));
                lst.Add(new Classparametros("@Cod_vaca", cod_madre));
                lst.Add(new Classparametros("@Raza", raza));
                lst.Add(new Classparametros("@Fech_nac", fech_nac));
                lst.Add(new Classparametros("@Tip_proc", tip_procreacion));
                lst.Add(new Classparametros("@Foto", foto_ternero));
                

                lst.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));

                Cnt.Exec_sp("reg_ternero", lst);

                report = lst[6].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return report;
        }

        public DataTable listar_terneros() {

            return Cnt.Listar_datos("list_terneros",null);
        }

    }
}
