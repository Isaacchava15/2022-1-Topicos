using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.Codigo.Dados.BL;

namespace Topicos.Codigo.Warming
{
    public class JuegoDeDados
    {

        public void InicieElJuego()
        {
           int veces = ObtenerVecesDeTirarElDado();
            TirarLosDadosEneVeces(veces);
        }

        private void TirarLosDadosEneVeces(int veces)
        {
            var dado1 = new Dado();
            var dado2 = new Dado();
            for (int i = 0; i < veces; i++)
            {
                TirarLosDadosUnaVez(dado1, dado2);
                MuestreElResultado(i, dado1, dado2); 
            }
        }

        private void MuestreElResultado(int iteracion, Dado dado1, Dado dado2)
        {
            System.Console.WriteLine($"En la iteracion: {iteracion} el dado 1 salio en: {dado1.Valor} y el dado 2 salio en: {dado2.Valor}.");
        }

        private void TirarLosDadosUnaVez(Dado dado1, Dado dado2)
        {
            dado1.Tirar();
            dado2.Tirar();
        }

        private int ObtenerVecesDeTirarElDado()
        {
            var veces = 0;
            var elValorCapturado = string.Empty;
            var capturaExitosa = false;
            while (! capturaExitosa)
            {
                System.Console.Write("Digite cantidad de veces que desea tirar los dados: ");
                elValorCapturado = System.Console.ReadLine();
                capturaExitosa = int.TryParse(elValorCapturado, out veces);
                if (! capturaExitosa)
                {
                    System.Console.WriteLine("El valor digitado no es valido.");
                }
                
            }
            
            return veces;
        }
    }
}
