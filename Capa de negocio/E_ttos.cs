using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_acceso;
using System.Data;

namespace Capa_de_negocio
{
    public class E_ttos
    {
        public String descrip { get; set; }
        public String medicamento { get; set; }
        public DateTime fecha_tto { get; set; }
        public int? cod_toro { get; set; }
        public int? cod_vaca { get; set; }
        public int? cod_ternero { get; set; }

        Classconexion Cnt = new Classconexion();
        public String Registrar_tto_toro() {
            String report = "";
            List<Classparametros> lst = new List<Classparametros>();

            try
            {
                lst.Add(new Classparametros("@Descripción", descrip));
                lst.Add(new Classparametros("@Medicina", medicamento));
                lst.Add(new Classparametros("@Fech_tto", fecha_tto));
                lst.Add(new Classparametros("@Cod_toro", cod_toro));
                lst.Add(new Classparametros("@Cod_vaca", DBNull.Value));
                lst.Add(new Classparametros("@Cod_ternero",DBNull.Value));

                lst.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                Cnt.Exec_sp("reg_ttos", lst);

                report = lst[6].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return report;
        }

        public String Registrar_tto_vaca() {
            String report = "";
            List<Classparametros> lst = new List<Classparametros>();

            try
            {
                lst.Add(new Classparametros("@Descripción", descrip));
                lst.Add(new Classparametros("@Medicina", medicamento));
                lst.Add(new Classparametros("@Fech_tto", fecha_tto));
                lst.Add(new Classparametros("@Cod_toro", DBNull.Value));
                lst.Add(new Classparametros("@Cod_vaca", cod_vaca));
                lst.Add(new Classparametros("@Cod_ternero", DBNull.Value));

                lst.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                Cnt.Exec_sp("reg_ttos", lst);

                report = lst[6].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return report;
        }

        public String Registrar_tto_ternero() {
            String report = "";
            List<Classparametros> lst = new List<Classparametros>();

            try
            {
                lst.Add(new Classparametros("@Descripción", descrip));
                lst.Add(new Classparametros("@Medicina", medicamento));
                lst.Add(new Classparametros("@Fech_tto", fecha_tto));
                lst.Add(new Classparametros("@Cod_toro", DBNull.Value));
                lst.Add(new Classparametros("@Cod_vaca", DBNull.Value));
                lst.Add(new Classparametros("@Cod_ternero", cod_ternero));

                lst.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                Cnt.Exec_sp("reg_ttos", lst);

                report = lst[6].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return report;
        }

        public DataTable Listar_ttos() {
            return Cnt.Listar_datos("list_ttos", null);
        }
    }
}
