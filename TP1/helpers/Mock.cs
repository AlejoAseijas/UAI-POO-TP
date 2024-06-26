﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.models;
using TP1.services;

namespace TP1.helpers
{
    public class Mock
    {
        public static void setMockData()
        {

            Proveedor provedor1 = new Proveedor { Nombre = "Proveedor 1" };
            Proveedor provedor2 = new Proveedor { Nombre = "Proveedor 2" };

            ProductoElectronico electronico1 = new ProductoElectronico("Electrónico", "Subcategoría 1", "Producto 1", "ALTO") { Provedor = provedor1 };
            ProductoElectronico electronico2 = new ProductoElectronico("Electrónico", "Subcategoría 2", "Producto 2", "MEDIO") { Provedor = provedor2 };

            ProductoAlimenticio alimenticio1 = new ProductoAlimenticio("Alimenticio", "Subcategoría 1", "Producto 3", DateTime.Now.AddDays(30)) { Provedor = provedor1 };
            ProductoAlimenticio alimenticio2 = new ProductoAlimenticio("Alimenticio", "Subcategoría 2", "Producto 4", DateTime.Now.AddDays(60)) { Provedor = provedor2 };

            Inventario inventario1 = new Inventario(10, 100, 200, electronico1);
            Inventario inventario2 = new Inventario(5, 150, 250, electronico2);
            Inventario inventario3 = new Inventario(20, 80, 150, alimenticio1);
            Inventario inventario4 = new Inventario(15, 120, 220, alimenticio2);

            Cliente cliente1 = new Cliente() { Nombre = "Juan", Apellido = "Pérez", DNI = "12345678" };
            Cliente cliente2 = new Cliente() { Nombre = "María", Apellido = "García", DNI = "87654321" };
            Cliente cliente3 = new Cliente() { Nombre = "Pedro", Apellido = "López", DNI = "11223344" };
            Cliente cliente4 = new Cliente() { Nombre = "Ana", Apellido = "Martínez", DNI = "44332211" };

            ProductoService.ObtenerInstancia().items = new List<models.Inventario> { inventario1, inventario2, inventario3, inventario4 };
            ClienteService.ObtenerInstancia().items = new List<models.Cliente> {  cliente1, cliente2, cliente3, cliente4 };

        }
    }
}
