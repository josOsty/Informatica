using System;

namespace Informatica.Negocio.Tests
{
    public class Comparador
    {
        public int ObtenerMenor(int primerElemento, int segundoElemento)
        {
            //ejemplo con if
            /*if (primerElemento < segundoElemento)

                 return primerElemento;
                 else//refactorizar
                    return segundoElemento;*/

            //otra froma de refactorizar la sentencia if
            return primerElemento < segundoElemento ? primerElemento : segundoElemento;
            
        }

        public int ObtenerMayor(int primerElemento, int segundoElemento)
        {
            return primerElemento > segundoElemento ? primerElemento : segundoElemento;
        }
    }
}