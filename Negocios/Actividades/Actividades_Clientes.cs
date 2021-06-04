using Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Actividades
{
    public class Actividades_Clientes : Interfaces.ICRUD<Cliente>
    {
        Datos.DTO_Clientes dto_clientes = new Datos.DTO_Clientes();
        public bool Create(Cliente Entidad)
        {
            return dto_clientes.Create(Entidad);
        }

        public bool Delete(Cliente Entidad)
        {
            return dto_clientes.Delete(Entidad);
        }

        public Cliente Read(object ID)
        {
            return dto_clientes.Read(ID);
        }

        public List<Cliente> ReadAll()
        {
            return dto_clientes.ReadAll();
        }

        public bool Update(Cliente Entidad)
        {
            return dto_clientes.Update(Entidad);
        }
    }
}
