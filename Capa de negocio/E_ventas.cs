using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_acceso;
using System.Data;

namespace Capa_de_negocio
{
    public class E_ventas
    {
        public int precio { get; set; }
        public DateTime fecha { get; set; }
        public int cod_toro { get; set; }
        public int cod_vaca { get; set; }

        Classconexion Cnt = new Classconexion();

        public String Registrar_venta_toro()
        {
            String report = "";
            List<Classparametros> lst = new List<Classparametros>();

            try
            {
                lst.Add(new Classparametros("@Precio", precio));
                lst.Add(new Classparametros("@Fech_v", fecha));
                lst.Add(new Classparametros("@Cod_toro", cod_toro));
                lst.Add(new Classparametros("@Cod_vaca", DBNull.Value));

                lst.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                Cnt.Exec_sp("reg_ventas", lst);
                report = lst[4].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return report;
        }

        public String Registrar_venta_vaca()
        {
            String report = "";
            List<Classparametros> lst = new List<Classparametros>();

            try
            {
                lst.Add(new Classparametros("@Precio", precio));
                lst.Add(new Classparametros("@Fech_v", fecha));
                lst.Add(new Classparametros("@Cod_toro", DBNull.Value));
                lst.Add(new Classparametros("@Cod_vaca", cod_vaca));

                lst.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                Cnt.Exec_sp("reg_ventas", lst);
                report = lst[4].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return report;
        }
        public DataTable Listar_ventas()
        {
            return Cnt.Listar_datos("list_ventas",null);
        }
    }
}
