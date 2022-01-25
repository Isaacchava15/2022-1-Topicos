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

        
       
        public Dado()
        {
            Valor = _NoInicializado;
        }


        //Constructor con un valor del dado
        public Dado(int valor)
        {
            Valor = valor;
        }

        //Accion de tirar el dado 1 vez
        public void Tirar ()
        {
            var random = new Random();
            int elNumero = random.Next(1, 6);
            Valor = elNumero;
        }

        /// <summary>
        /// Accion de tirar el dado n veces
        /// </summary>
        /// <param name="cantidadVeces"> Cantidad de veces que se tira el dado</param>
        
        public void Tirar(int cantidadVeces)
        {
            for (int i = 0; i < cantidadVeces; i++)
            {
                this.Tirar();
            }
        }
    }
}