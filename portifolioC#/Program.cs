class AlgoritmosDeOrdenação { 

// Este programa demonstra o algoritmo Bubble Sort em um array de números inteiros.
// ...
    static void Main(string[] args) { 

        int[] array = { 96, 32, 85, 75, 12, 33 }; 

  

        Console.WriteLine("Array sem a ordenação: "); 

        for (int i = 0; i < array.Length; i++) { 

            Console.Write(array[i] + " "); 

        } 

  

        BubbleSort(array); 

  

        Console.WriteLine("\nArray com a ordenação: "); 

        for (int i = 0; i < array.Length; i++) { 

            Console.Write(array[i] + " "); 

        } 

    } 

  

    static void BubbleSort(int[] array) { 

        int n = array.Length; 

        for (int i = 0; i < n-1; i++) { 

            for (int j = 0; j < n-i-1; j++) { 

                if (array[j] > array[j+1]) { 

                    int temp = array[j]; 

                    array[j] = array[j+1]; 

                    array[j+1] = temp; 

                } 

            } 

        } 

    } 

} 
