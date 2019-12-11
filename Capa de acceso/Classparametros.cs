using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_de_acceso
{
    public class Classparametros
    {
        //Parametros
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType Tipodato { get; set; }
        public Int32 Tamanio { get; set; }
        public ParameterDirection Direccion { get; set; }

        //Constructores
        //Entrada
        public Classparametros(String objnombre, Object objvalor)
        {
            Nombre = objnombre;
            Valor = objvalor;
            Direccion = ParameterDirection.Input;
        }
        //Salida
        public Classparametros (String objnombre, SqlDbType objtipo,Int32 objtamanio)
        {
            Nombre = objnombre;
            Tipodato = objtipo;
            Tamanio = objtamanio;
            Direccion = ParameterDirection.Output;
        }
    }
}
