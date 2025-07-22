using System.ComponentModel;
using System.Globalization;
/* 
  Author: Angel David
  Date: 22 de julio 2025
  Descpition: uso del import de las divisas para poder hacer una calculadora de divisas versatil
*/
namespace Calculadora
{ 
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      System.Console.Write($"ahora ingrese una cantidad de {NumberFormatInfo.CurrentInfo.CurrencySymbol}\n-> ");
      double money = Convert.ToDouble(Console.ReadLine());

      // input del menu de la divisa sobre la cual se va a realizar la conversion
      System.Console.Write("ingrese el tipo de divisa al que desea utilizar:\n1. {0}\n2. {1}\n3. {2}\n4. {3}\n5. {4}\n5. {6}\n-> ", CultureInfo.CurrentCulture.Name);
      byte menu = Convert.ToByte(Console.ReadLine());
      // input del valor a convertir 
      double answer = 0;
      switch (menu)
      { 
        // pesos a dolares 
        case 1:
          double answer = money * 1;//no se que colocar para calcular el resultado de la divisa
        // pesos a euros
        case 2:
          double answer = money * 1;//no se que colocar para calcular el resultado de la divisa
        // pesos a yenes
        case 3:
          double answer = money * 1;//no se que colocar para calcular el resultado de la divisa~
        default:
          System.Console.WriteLine("error, vuelva a intentarlo");
          break;
      }
      NumberFormatInfo nfi = new CultureInfo($"{menu}", false).NumberFormat;
      Console.WriteLine(answer.ToString("C", nfi));
      nfi.CurrencyDecimalSeparator = " ";
      Console.WriteLine(answer.ToString("C", nfi));
      
      Console.WriteLine($"{answer.ToString("C3", new CultureInfo($"{menu}"))}");  

    }
  }
}
