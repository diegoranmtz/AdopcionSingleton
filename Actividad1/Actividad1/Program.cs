using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario usuario = new Usuario();
            //Perro perro = new Perro();

            Usuario usuario = Usuario.GetInstacia();
            Perro perro = Perro.GetInstancia();

            Console.WriteLine("¿Cúal es tu nombre?");
            usuario.nombre = Console.ReadLine();
            Console.WriteLine("¿Y el del perrito?");
            perro.nombre = Console.ReadLine();

            //Tramite tramite = new Tramite(perro, usuario);
            Tramite tramite = Tramite.GetInstancia(perro, usuario);
        }
    }
}
