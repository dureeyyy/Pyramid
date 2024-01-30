using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("How many lines do you want?");

    int lines = Convert.ToInt32(Console.ReadLine());

    //Not optmized solution
    /*for (int i = 1; i <= lines; i++){
      for (int s = i; s < lines; s++){
        Console.Write(" ");
      }
      for (int j = 0; j < i * 2 - 1; j++){
        Console.Write("*");
      }
      Console.WriteLine();
    }*/

    //Optmized solution
    for (int i = 1; i <= lines; i++) {
        // Print leading spaces
        Console.Write(new string(' ', lines - i));

        // Print asterisks
        Console.WriteLine(new string('*', i * 2 - 1));
    }

  }
}