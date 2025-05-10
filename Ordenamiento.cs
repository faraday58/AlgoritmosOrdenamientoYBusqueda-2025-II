using System;


namespace AlgoritmosOrdenamientoYBusqueda_2025_II
{
    public class Ordenamiento
    {

        public static void BubbleDesc(int [] v)
        {

            // 2 4 1 20 0 -4 9
            

            for (int i=0; i < v.Length; i++  )
            {
                for (int j = 0; j < v.Length - 1; j++)
                {
                    int aux = 0;
                    if (v[j] < v[j + 1])
                    {
                        aux = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aux;

                    }
                }
            }

        }



    }
}
