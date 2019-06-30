namespace Actividad1
{
    class Perro
    {
        public string nombre { get; set; }
        private int edad { get; set; }
        public string raza { get; set; }
        public Suscursal suscursal { get; set; }

        public static Perro instancia;

        private Perro() { }

        public static Perro GetInstancia()
        {
            if(instancia == null)
            {
                instancia = new Perro();
            }
            return instancia;
        }
    }
}