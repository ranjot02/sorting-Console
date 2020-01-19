using System;
using System.Collections;
using System.Collections.Generic;

class quicksort {
  public static void sort(double[] arr,int start,int end){
    if (start < end){ 
      int pi = partition(arr, start, end); 
      sort(arr, start, pi-1); 
      sort(arr, pi+1, end); 
    } 
  }
  private static int partition(double []arr, int start, int end){
    double pivot = arr[end];  

    int i = (start - 1);  
    for (int j = start; j < end; j++) 
    { 

      if (arr[j] < pivot) 
      { 
        i++;  
        double temp = arr[i]; 
        arr[i] = arr[j]; 
        arr[j] = temp; 
      } 
    } 
 
    double temp1 = arr[i+1]; 
    arr[i+1] = arr[end]; 
    arr[end] = temp1; 
    foreach (double item in arr){
      Console.Write(item+" ");
    }
    Console.WriteLine();
    return i+1; 
  } 


  static void quickSort(double []arr, int low, int high) { 
    if (low < high) { 

      int pi = partition(arr, low, high); 

      quickSort(arr, low, pi-1); 
      quickSort(arr, pi+1, high); 
    } 
  }
}
