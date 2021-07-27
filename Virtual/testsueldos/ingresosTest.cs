using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenarios;
using procesos;
using Virtual;
using Modelo.clases;
using Xunit;

namespace testsueldos
{
    public class ingresosTest
    {
        public ingresosTest()
        {
            Escenario01 escenario = new Escenario01();
            EscenarioControl control = new EscenarioControl();
            control.Grabar(escenario);
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
        // Pruebas cuantitativas
        [Theory]
        [InlineData(1, "Gabriel Fierro", 2000f)]
        [InlineData(2, "Daniela Guevara", 1200f)]
        [InlineData(3, "Kevin Masabanda", 618.75f)]
        [InlineData(4, "Maria Garcia", 700f)]
        [InlineData(5, "Karen Valladares", 1065f)]

        public void totalingresos(int empId, string emp, float resEsperado)
        {
            float resultado;
            using (var context = new ProyectoContext())
            {

                Ingresos ingresos = context.ingresos.Find(empId);

                ingresosProc opIngreso = new ingresosProc(context);
                resultado = opIngreso.ingresot(ingresos);
            }
            Assert.True(resEsperado == resultado, " Esperado " + resEsperado + " != " + resultado + " - " + emp);
        }
    }
}
