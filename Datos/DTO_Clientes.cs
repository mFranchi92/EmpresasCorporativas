using Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DTO_Clientes : Interfaces.ICRUD<Cliente>
    {
        public bool Create(Cliente Entidad)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=LAFAMILYPC\SQLVAINA; Initial Catalog=EmpresasCorporativas; Integrated Security=true";
                conn.Open();

                SqlParameter paramDNI = new SqlParameter(@"DNI", SqlDbType.NVarChar, 50);
                SqlParameter paramNOMBRE = new SqlParameter(@"NOMBRE", SqlDbType.NVarChar, 50);
                SqlParameter paramAPELLIDO = new SqlParameter(@"APELLIDO", SqlDbType.NVarChar, 50);

                paramDNI.Value = Entidad.DNI;
                paramNOMBRE.Value = Entidad.Nombre;
                paramAPELLIDO.Value = Entidad.Apellido;

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;

                comm.Parameters.Add(paramDNI);
                comm.Parameters.Add(paramNOMBRE);
                comm.Parameters.Add(paramAPELLIDO);

                comm.CommandText = "Create_Cliente";
                comm.CommandType = CommandType.StoredProcedure;

                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(Cliente Entidad)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=LAFAMILYPC\SQLVAINA; Initial Catalog=EmpresasCorporativas; Integrated Security=true";
                conn.Open();

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;

                SqlParameter paramDNI = new SqlParameter("@DNI", SqlDbType.NVarChar, 50);
                paramDNI.Value = Entidad.DNI;
                comm.Parameters.Add(paramDNI);
                comm.CommandText = "Delete_Cliente";
                comm.CommandType = CommandType.StoredProcedure;

                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Cliente Read(object ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAFAMILYPC\SQLVAINA; Initial Catalog=EmpresasCorporativas; Integrated Security=true";
            conn.Open();

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT DNI, NOMBRE, APELLIDO FROM CLIENTES WHERE DNI =" + ID.ToString();

            SqlDataReader dr = comm.ExecuteReader();

            dr.Read();

            Cliente ClienteObtenido = new Cliente();

            ClienteObtenido.DNI = dr["DNI"].ToString();
            ClienteObtenido.Nombre = dr["NOMBRE"].ToString();
            ClienteObtenido.Apellido = dr["APELLIDO"].ToString();

            conn.Close();

            return ClienteObtenido;
        }

        public List<Cliente> ReadAll()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAFAMILYPC\SQLVAINA; Initial Catalog=EmpresasCorporativas; Integrated Security=true";
            conn.Open();

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT DNI, NOMBRE, APELLIDO FROM CLIENTES";
            SqlDataReader dr = comm.ExecuteReader();

            List<Cliente> ListadoDeClientes = new List<Cliente>();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.DNI = dr["DNI"].ToString();
                cliente.Nombre = dr["NOMBRE"].ToString();
                cliente.Apellido = dr["APELLIDO"].ToString();

                ListadoDeClientes.Add(cliente);
            }
            conn.Close();
            return ListadoDeClientes;
        }

        public bool Update(Cliente Entidad)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=LAFAMILYPC\SQLVAINA; Initial Catalog=EmpresasCorporativas; Integrated Security=true";
                conn.Open();

                SqlParameter paramDNI = new SqlParameter(@"DNI", SqlDbType.NVarChar, 50);
                SqlParameter paramNOMBRE = new SqlParameter(@"NOMBRE", SqlDbType.NVarChar, 50);
                SqlParameter paramAPELLIDO = new SqlParameter(@"APELLIDO", SqlDbType.NVarChar, 50);

                paramDNI.Value = Entidad.DNI;
                paramNOMBRE.Value = Entidad.Nombre;
                paramAPELLIDO.Value = Entidad.Apellido;

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;

                comm.Parameters.Add(paramDNI);
                comm.Parameters.Add(paramNOMBRE);
                comm.Parameters.Add(paramAPELLIDO);

                comm.CommandText = "Update_Cliente";
                comm.CommandType = CommandType.StoredProcedure;

                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
