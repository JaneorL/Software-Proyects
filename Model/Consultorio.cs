namespace Model
{
    public class Consultorio
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string encargado;

        public string Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }

        private string fechareg;

        public string FechaReg
        {
            get { return fechareg; }
            set { fechareg = value; }
        }

        public Consultorio(string nombre, string direccion, string encargado, string fechareg)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.encargado = encargado;
            this.fechareg = fechareg;
        }

        public Consultorio()
        {

        }
    }
}