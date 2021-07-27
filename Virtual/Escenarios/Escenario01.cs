using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Escenarios.Escenario;
using Modelo.clases;
using Modelo;

namespace Escenarios
{
    public class Escenario01 : Escenario, IEscenario
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> carga()
        {
            //Sucursal
            Sucursal sucursal1 = new()
            {
                Ciudad = "Quito",
                Direccion = "Panamericana Nte./E28B y Av. Eloy Alfaro",
            };
            Sucursal sucursal2 = new()
            {
                Ciudad = "Guayaquil",
                Direccion = "Panamericana/Troncal de la Sierra/E35 y E487",

            };

            List<Sucursal> lstSucursal = new()
            {
                sucursal1,
                sucursal2
            };

            datos.Add(ListaTipo.Sucursal, lstSucursal);
            //Empleados
            Empleado gabriel = new()
            {
                Nombre = "Gabriel Fierro",
                Telefono = 0996174424,
                Cargo = "Gerente",
                Sucursal = sucursal1
            };
            Empleado maria = new()
            {
                Nombre = "Maria Garcia",
                Telefono = 0996175412,
                Cargo = "Contadora",
                Sucursal = sucursal2
            };
            Empleado daniela = new()
            {
                Nombre = "Daniela Guevara",
                Telefono = 0996174894,
                Cargo = "Secretaria",
                Sucursal = sucursal1
            };
            Empleado kevin = new()
            {
                Nombre = "Kevin Masabanda",
                Telefono = 0996187365,
                Cargo = "Asistente de Gerencia",
                Sucursal = sucursal1
            };
            Empleado karen = new()
            {
                Nombre = "Karen Valladares",
                Telefono = 0996198221,
                Cargo = "Vendedora",
                Sucursal = sucursal2
            };
            List<Empleado> lstEmpleado = new()
            {
                gabriel,
                maria,
                daniela,
                kevin,
                karen
            };
            datos.Add(ListaTipo.Empleados, lstEmpleado);
            
            //Empresa
            Configuracion CreterToursQuito = new()
            {
                NombreEmpresa = "CreterTours Quito",
                MinHorasExtra = 12
            };
            List<Configuracion> lstConfig = new()
            {
                CreterToursQuito,
            };
            datos.Add(ListaTipo.Configuracion, lstConfig);
            return datos;
        }
    }
}
