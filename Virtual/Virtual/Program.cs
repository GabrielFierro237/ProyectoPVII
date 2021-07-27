using System;
using Escenarios;
using System.Linq;
using Modelo.clases;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Virtual
{
    class Program
    {
        public static void Main(string[] args)
        {

            var Escenario = new Escenario01();
            var EscenarioControl = new EscenarioControl();
            EscenarioControl.Grabar(Escenario);
            //grabar datos de ingresos
            var datosing = new datosIngreso();
            datosing.Generar();
            //grabar datos de deducciones
            var datosded = new datosDeducciones();
            datosded.Generar();
            //grabar datos de sueldo
            var datossueldo = new datosSueldo();
            datossueldo.Generar();
        }
    }
}
