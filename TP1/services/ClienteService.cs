using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Exceptions;
using TP1.helpers;
using TP1.models;

namespace TP1.services
{
    public class ClienteService : AbmOperation<Cliente>
    {
        public static List<Cliente> CLIENTES = new List<Cliente>();
        private static readonly ClienteService clienteServiceInstance = new ClienteService();

        public ClienteService()
        {
        }

        public static ClienteService ObtenerInstancia()
        {
          return clienteServiceInstance;
        }

        public void Alta(Cliente obj)
        {
            if (!CLIENTES.Contains(obj))
            {
                CLIENTES.Add(obj);
            }
            else
            {
                throw new DuplicatedException("El cliente ya existe");
            }
        }

        public void Baja(Cliente obj)
        {
            CLIENTES.Remove(obj);
        }

        public void Modificar(Cliente obj1, Cliente obj2)
        {
            foreach (Cliente cliente in CLIENTES) 
            {
                if (obj1.Equals(cliente)) 
                {
                    cliente.Nombre = obj2.Nombre;
                    cliente.Apellido = obj2.Apellido;
                    cliente.DNI = obj2.DNI;

                }
            }
        }
    }
}
