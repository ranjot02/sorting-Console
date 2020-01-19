using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    List<double> data = new List<double>();
    bool loop = true;
    while (loop == true){
    int n = data.Count;
      Console.WriteLine("\n1. Add to list\n2. View list\n3. Clear list\n4. Sort list\n5. End");
      string todo=Console.ReadLine();
      if (todo == "1"){
        addarray(ref data);
      }
      else if (todo == "2"){
        foreach (double item in data){
          Console.Write(item+ " ");
        }
        Console.WriteLine();
      }
      else if (todo == "3"){
        data.Clear();
      }
      else if (todo == "4"){
        sortopt(data ,n);
      } 
      else if (todo =="5"){
        loop = false;
      }
      else {
        Console.WriteLine("That is invalid");
      }
    }
  }

  static void addarray(ref List<double> data){
    Console.WriteLine("Enter value to list");
    double userval = Convert.ToDouble(Console.ReadLine());
    data.Add(userval);
  }
  static void sortopt(List<double> data,int n){
    Console.WriteLine("\nWhat method\n1. Bubble sort\n2. Merge Sort\n3. Quick sort");
    string sorter = Console.ReadLine();
    if (sorter == "1"){
        bubblesort.sort(data.ToArray(), n);
    }
    else if (sorter == "2"){
      mergesort.sort(data.ToArray(), 0, (n - 1));
    }
    else if (sorter == "3"){
      quicksort.sort(data.ToArray(),0,(n-1));
    }
    else{
      Console.WriteLine("That is invalid");
    }
  }
}