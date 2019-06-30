
namespace Actividad1
{
    class Usuario : Persona
    {
        private static Usuario instacia;
        public Dinero dinero { get; set; }

        private Usuario() { }

        public static Usuario GetInstacia()
        {
            if(instacia == null)
            {
                instacia = new Usuario();
            }
            return instacia;
        }
    }
}
