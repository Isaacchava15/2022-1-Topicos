namespace Topicos.Codigo.Dados.BL
{
    //Clase para la logica de negocio de los dados
    public class Dado
    {
        const int  _NoInicializado = -1;
        //Propiedades
        private int _valor;

        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        //Metodos
       
        public Dado()
        {
            Valor = _NoInicializado;
        }

        public Dado(int valor)
        {
            Valor = valor;
        }

        public void Tirar ()
        {
            var random = new Random();
            int elNumero = random.Next(1, 6);
            Valor = elNumero;
        }

        public void Tirar(int cantidadVeces)
        {
            for (int i = 0; i < cantidadVeces; i++)
            {
                this.Tirar();
            }
        }
    }
}