using System;
using System.Collections;
using System.Collections.Generic;

class bubblesort{

  public static void sort( double[] arr, int n){
    double temp;
    bool swap = true;
    do{
      for(int j = 0; swap == true; j++)
      {
        swap = false;
        for(int k = 0; k < n-j-1; k++)
        {
          if( arr[k] > arr[k+1])
          {
            // swap the elements
            temp = arr[k];
            arr[k] = arr[k+1];
            arr[k+1] = temp;
            swap = true;
          } 
        }
        foreach( double item in arr)//each pass
        {
          Console.Write(item+ " ");
        }
        Console.WriteLine();
      }
    } while (swap == true);
  }
}