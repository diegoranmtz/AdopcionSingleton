using System;

namespace Actividad1
{
    class Tramite
    {

        private static Tramite instancia;

        private Tramite() { }
        private Tramite(Perro perro, Usuario usuario) { realizarAdopcion(perro, usuario); }

        public int folio { get; set; }
        public void realizarAdopcion(Perro perro, Usuario usuario)
        {
            Console.WriteLine("Estimado: " + usuario.nombre + "\nHaz adoptado a " + perro.nombre);
            Console.WriteLine("Saludos.");
            Console.ReadLine();
        }

        public static Tramite GetInstancia(Perro perro, Usuario usuario)
        {
            if(instancia == null)
            {
                instancia = new Tramite(perro, usuario);
            }
            return instancia;
        }
    }
}