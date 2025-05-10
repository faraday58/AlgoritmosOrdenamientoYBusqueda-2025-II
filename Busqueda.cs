

namespace AlgoritmosOrdenamientoYBusqueda_2025_II
{
    public class Busqueda
    {
        public static int Directa(int[] v, int x)
        {
            for (int i= 0; i < v.Length; i++)
            {
                if (v[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
