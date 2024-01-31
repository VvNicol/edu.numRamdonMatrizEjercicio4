namespace edu.numRamdonMatrizEjercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matrix de 2*3 para una tabla
            int[,] tabla = new int[3, 2];

            //rellena la tabla con numeros aleatorios del 1,100
            Random random = new Random();
            for(int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                   tabla[fila, columna] = random.Next(1, 101);
                }
            }
            Console.WriteLine("################");
            Console.WriteLine("Antes de ordenar");

            MostrarTabla(tabla);
            ordenarColumnas(tabla);
            Console.WriteLine("################");

            Console.WriteLine("Despues de ordenar");
            MostrarTabla(tabla);

            
            ValorMinimoMaximo(tabla);
            MediaAritmetrica(tabla);
        }

        private static void MediaAritmetrica(int[,] tabla)
        {
            for(int fila = 0; fila < tabla.GetLength(0); fila++)
    {
                int suma = 0;

                for (int columna = 0; columna < tabla.GetLength(1); columna++)
                {
                    suma += tabla[fila, columna];
                }

                double media = (double)suma / tabla.GetLength(1);
                Console.WriteLine("La media aritmética de la fila " + (fila + 1) +" es " + (media));
            }
        }

        private static void ValorMinimoMaximo(int[,] tabla)
        {
           int minimo = tabla[0, 0];
           int maximo = tabla[0, 0];

            for(int fila = 0; fila < 3; fila++)
            {
                for(int columna = 0;columna < 2; columna++)
                {
                    if (tabla[fila, columna] < minimo)
                    {
                        minimo = tabla[fila, columna];
                        
                    }
                    if (tabla[fila, columna] > maximo)
                    {
                        maximo = tabla[fila, columna];
                       
                    }
                }
            }
            Console.WriteLine("Valor minimo: "+ minimo);
            Console.WriteLine("Valor maximo: "+ maximo);
        }

        private static void ordenarColumnas(int[,] tabla)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3 - 1; j++)
                {
                    if (tabla[j, i] > tabla[j + 1, i])
                    {
                        // Intercambia los elementos
                        int temp = tabla[j, i];
                        tabla[j, i] = tabla[j + 1, i];
                        tabla[j + 1, i] = temp;
                    }
                }
            }
        }

        private static void MostrarTabla(int[,] tabla)
        {
           for(int fila =0; fila < tabla.GetLength(0); fila++)
            {
                for (int columna = 0;columna < tabla.GetLength(1); columna++)
                {
                    Console.Write(tabla[fila, columna]+ "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
