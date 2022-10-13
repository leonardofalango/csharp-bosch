using System;

// conseguimos declarar funcao dentro de funcao
// por isso é possível declarar funções aqui
void merge_sort_ref(
    int[] arr,
    int[] arr_aux,
    int inicio, int fim)
{
    if (fim - inicio < 2)
        return;
    int pivo = (inicio + fim) / 2;
    merge_sort_ref(arr, arr_aux, inicio, pivo);
    merge_sort_ref(arr, arr_aux, pivo, fim);
    merge(arr, arr_aux, inicio, pivo, fim);

}


void merge(
    int[] arr,
    int[] arr_aux,
    int inicio_primeiro, int inicio_segundo, int fim)
{
    int i = inicio_primeiro, j = inicio_segundo, k = inicio_primeiro;

    while (i < inicio_segundo && j < fim)
    {
        if (arr[i] < arr[j])
        {
            arr_aux[k] = arr[i];
            i++; k++;
        }
        else
        {
            arr_aux[k] = arr[j];
            k++; j++;
        }
    }

    while (i < inicio_segundo)
    {
        arr_aux[k] = arr[i];
        i++; k++;
    }

    while (j < fim)
    {
        arr_aux[k] = arr[j];
        k++;j++;
    }

    for (int index = inicio_primeiro; index < fim; index++){
        arr[index] = arr_aux[index];
    }

}


void merge_sort(int[] arr)
{
    int fim = arr.Length;
    int[] arr_aux = new int[fim];
    merge_sort_ref(arr, arr_aux, 0, fim);
}



int[] array = new int[10] {7, 8, 2, 3, 1, 2, 5, 9, 4, 10};

foreach (var n in array)
    Console.Write($"{n} |");

Console.WriteLine();
merge_sort(array);

foreach (var n in array)
    Console.Write($"{n} |");