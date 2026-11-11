using System;
using System.Collections.Generic;
using System.Text;

namespace AdivinaElNumero.BA
{
    public class Juego
    {
        //Número secreto que el jugador debe adivinar
        private int numeroSecreto;
        //Cantidad de inetntos realizados por el jugador

        public int Intentos { get; private set; }

        //indica si el juego ha terminado(se adivino el numero)
        public bool JuegoTerminado { get; private set; }

        //constructor:genera un número aleatorio entre 1 y 100
        public Juego()
        {
            Random aleatorio= new Random();
            numeroSecreto = aleatorio.Next(1, 100);
            Intentos = 0;
            JuegoTerminado = false;
        }
        //Metodo para probar un número. Devuelve :
        //-1 si el número es menor que el número secreto
        //1 si el número es mayor que el número secreto
        //0 si acertó el número secreto
        public int ProbarNumero(int numero)
        {
            Intentos++;
            if (numero < numeroSecreto)
            {
                return -1;
            }
            else if (numero > numeroSecreto)
            {
                return 1;
            }
            else
            {
                JuegoTerminado = true;
                return 0;
            }
        }
    }
}
