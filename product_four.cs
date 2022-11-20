using System;
class HelloWorld {
  static void Main() {
    int product;
    Console.WriteLine("Enter the four value:");
    int n1=Convert.ToInt32(Console.ReadLine());
    int n2=Convert.ToInt32(Console.ReadLine());
    int n3=Convert.ToInt32(Console.ReadLine());
    int n4=Convert.ToInt32(Console.ReadLine());
    product=n1*n2*n3*n4;
    Console.WriteLine("The Product of Four Value is :"+product);
    
    }
} 