using System;

namespace LogicaNegocio
{
    public class Envio
    {

        public static int CalcularVentasDeCarne(int PesoDeLaCarnekg, int TipoDeCarne, bool ConDescuento)
        {
            int PrecioTotal = 0, PrecioPorL = 0;

            if(TipoDeCarne == 1){
                if (ConDescuento)
                {
                    PrecioPorL = 2500;
                }
                else
                {
                    PrecioPorL = 3200;
                }
            }
            else if(TipoDeCarne == 2)
            {
                if (ConDescuento)
                {
                    PrecioPorL = 2000;
                }
                else
                {
                    PrecioPorL = 2800;
                }
            }
            else if (TipoDeCarne == 3)
            {
                if (ConDescuento)
                {
                    PrecioPorL = 3500;
                }
                else
                {
                    PrecioPorL = 4200;
                }
            }
            
            

            PrecioTotal = PrecioPorL * PesoDeLaCarnekg;

            return PrecioTotal;
        }

    }
}
