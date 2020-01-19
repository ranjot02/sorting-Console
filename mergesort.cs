using System;
using System.Collections;
using System.Collections.Generic;

class mergesort {
  public static void sort( double[] arr, int start,int end){
    if( start < end ) {
      int mid = (start + end) / 2 ;           
      sort(arr, start , mid ) ;
      sort(arr, mid+1 , end ) ;              
      merge(arr, start , mid , end );
    }
  }
  public static void merge( double[] arr , int start, int mid, int end){
    Console.WriteLine();
    int i, j, k;
    int n1 = mid-start+1;
    int n2 = end-mid;
    double[] L = new double[n1];
    double[] R = new double[n2];

    for (i = 0; i < n1; i++) 
      L[i] = arr[start + i]; 
    for (j = 0; j < n2; j++) 
      R[j] = arr[mid + 1+ j]; 

    i = 0; // Initial index of first subarray 
    j = 0; // Initial index of second subarray 
    k = start; // Initial index of merged subarray 
    while (i < n1 && j < n2) 
    { 
        if (L[i] <= R[j]) 
        { 
            arr[k] = L[i]; 
            i++; 
        } 
        else
        { 
            arr[k] = R[j]; 
            j++; 
        } 
        k++; 
    } 
  
    /* Copy the remaining elements of L[], if there 
       are any */
    while (i < n1) 
    { 
        arr[k] = L[i]; 
        i++; 
        k++; 
    } 
  
    /* Copy the remaining elements of R[], if there 
       are any */
    while (j < n2) 
    { 
        arr[k] = R[j]; 
        j++; 
        k++; 
    } 
  foreach (double item in arr){
    Console.Write(item+" ");}
  }
}
