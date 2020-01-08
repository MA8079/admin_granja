using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_acceso;
using System.Data;
namespace Capa_de_negocio
{
    public class Ectrl_peso
    {
        public Double peso { get; set; }
        public DateTime fech_ctrl { get; set; }
        public int? cod_toro { get; set;}
        public int? cod_vaca { get; set; }
        public int? cod_ternero{get; set;}

        Classconexion ccont = new Classconexion();

        public String reg_peso_toro() {
            String reporte = "";
            List<Classparametros> lpms = new List<Classparametros>();
            try
            {
                //Parametros de entrada
                lpms.Add(new Classparametros("@Peso", peso));
                lpms.Add(new Classparametros("@Fech_ctrl", fech_ctrl));
                lpms.Add(new Classparametros("@Cod_toro", cod_toro));
                lpms.Add(new Classparametros("@Cod_vaca", DBNull.Value));
                lpms.Add(new Classparametros("@Cod_ternero", DBNull.Value));

                //Parametros de salida
                lpms.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                ccont.Exec_sp("ctrl_pesotoro", lpms);
                reporte = lpms[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
            return reporte;
        }

        public String reg_peso_vaca()
        {
            String reporte = "";
            List<Classparametros> lpms = new List<Classparametros>();
            try
            {
                //Parametros de entrada
                lpms.Add(new Classparametros("@Peso", peso));
                lpms.Add(new Classparametros("@Fech_ctrl", fech_ctrl));
                lpms.Add(new Classparametros("@Cod_toro", DBNull.Value));
                lpms.Add(new Classparametros("@Cod_vaca", cod_vaca));
                lpms.Add(new Classparametros("@Cod_ternero",DBNull.Value));

                //Parametros de salida
                lpms.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));

                ccont.Exec_sp("ctrl_pesovaca", lpms);
                reporte = lpms[5].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return reporte;
        }

        public String reg_peso_ternero()
        {
            String reporte = "";
            List<Classparametros> lpms = new List<Classparametros>();
            try
            {
                //Parametros de entrada
                lpms.Add(new Classparametros("@Peso", peso));
                lpms.Add(new Classparametros("@Fech_ctrl", fech_ctrl));
                lpms.Add(new Classparametros("@Cod_toro",DBNull.Value));
                lpms.Add(new Classparametros("@Cod_vaca",DBNull.Value));
                lpms.Add(new Classparametros("@Cod_ternero", cod_ternero));

                //Parametros de salida
                lpms.Add(new Classparametros("@Reporte", SqlDbType.NVarChar, 50));
                ccont.Exec_sp("ctrl_pesoter", lpms);
                reporte = lpms[5].Valor.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return reporte;
        }
        public DataTable listar_peso() {
            return ccont.Listar_datos("list_peso", null);
        }

        public void Contenedor_params(List<Classparametros> lpms) {
            
           

        }
    }
}
