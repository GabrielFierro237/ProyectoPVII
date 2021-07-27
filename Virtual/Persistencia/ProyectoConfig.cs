using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Virtual;

namespace Persistencia
{
    public class ProyectoConfig
    {
        static public string PersistenciaDestino;
        static public string connectionString;
        static public bool modoVirtual;
        static public string DBMemory;

        static ProyectoConfig() {
            //Lectura de los parámetros del sistema
            PersistenciaDestino = ConfigurationManager.AppSettings["PersistenciaDestino"].ToString();
            connectionString = ConfigurationManager.ConnectionStrings[PersistenciaDestino].ToString();
            //Debug
            Console.WriteLine(PersistenciaDestino + " " + connectionString);
        }

        static public DbContextOptions<ProyectoContext> ContextOptions()
        {

            DbContextOptions<ProyectoContext> opciones = null;
            modoVirtual = true;
            switch (PersistenciaDestino)
            {
                case "SQLServerProyecto":
                    opciones = new DbContextOptionsBuilder<ProyectoContext>()
                        .UseSqlServer(connectionString)
                        .Options;
                    break;
                case "PostgresProyecto":
                    opciones = new DbContextOptionsBuilder<ProyectoContext>()
                        .UseNpgsql(connectionString)
                        .Options;
                    break;
                case "memoriaProyecto":
                    if (modoVirtual)
                    {
                        opciones = new DbContextOptionsBuilder<ProyectoContext>()
                            .UseInMemoryDatabase(connectionString)
                            .Options;  
                    }
                    break;
                default:
                    break;
            }
            return opciones;
        }
    }
}
