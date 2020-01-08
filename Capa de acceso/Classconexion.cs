using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_de_acceso
{
    public class Classconexion
    {
        SqlConnection Oconexion = new SqlConnection("Server=LAPTOP-NKDVUSVE\\SQLEXPRESS;Database=Granja_MA;UID=tryuser;PWD=741852");
        //Conexion
        //Apertura
         public void Open_conexion()
        {
            if (Oconexion.State == ConnectionState.Closed)
            {
                Oconexion.Open();
            }
            
        }
        //Cierre
        public void Close_conexion()
        {
            if (Oconexion.State == ConnectionState.Open)
            {
                Oconexion.Close();
            }
           
        }
        //Ejecucion de SP´s
        public void Exec_sp(String nombre, List <Classparametros> list_params)
        {
            SqlCommand clt;
            try
            {
                Open_conexion();
                clt = new SqlCommand(nombre,Oconexion);
                clt.CommandType = CommandType.StoredProcedure;
                if (list_params != null) //Validación de lista
                {
                    for(int i = 0; i < list_params.Count; i++)
                    {
                        if (list_params[i].Direccion == ParameterDirection.Input)//Verificar si parametro es de entrada
                        {
                           

                            //CODIGO INICIAL ►►►
                            clt.Parameters.AddWithValue(list_params[i].Nombre,list_params[i].Valor); //Indicar los parametros del constructor de entrada de la clase parametros 
                            
                        }
                        if (list_params[i].Direccion == ParameterDirection.Output)
                        {
                            clt.Parameters.Add(list_params[i].Nombre, list_params[i].Tipodato, list_params[i].Tamanio).Direction = ParameterDirection.Output; //Especificar la dirección de parametros
                        }
                    }
                    clt.ExecuteNonQuery(); //Ejecutar la transacción
                    //Recuperar el parametro de salida
                    for(int i = 0; i < list_params.Count; i++)
                    {
                        if (list_params[i].Direccion == ParameterDirection.Output)
                        {
                            list_params[i].Valor = clt.Parameters[i].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
               Close_conexion();
        }
        //Listar consulta SQL
        public DataTable Listar_datos (String nombre_sp, List<Classparametros> list_params)
        {
            DataTable ldt = new DataTable();
            SqlDataAdapter sda;
            try
            {
                sda = new SqlDataAdapter(nombre_sp, Oconexion);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (list_params != null)
                {
                    for(int i = 0; i < list_params.Count; i++)
                    {
                        sda.SelectCommand.Parameters.AddWithValue(list_params[i].Nombre, list_params[i].Valor);
                    }
                }
                //Llenar data table
                sda.Fill(ldt);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return ldt;
        }
        
        
    }
}
