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
      bool validacion = true;
      do
      {
        // esto es para permitir caracteres especiales pero no es necesario en este caso
        // Console.OutputEncoding = System.Text.Encoding.UTF8;

        // esto es el input de la cantidad de dinero en pesos
        System.Console.WriteLine();
        System.Console.Write($"usuario, ingrese una cantidad de {NumberFormatInfo.CurrentInfo.CurrencySymbol} en {CultureInfo.CurrentCulture.Name}\n-> ");
        double money = Convert.ToDouble(Console.ReadLine());
        if (money <= 0)
        {
          System.Console.WriteLine("no se valuen valores negativos o 0");
          return;
        }
        
        // input del menu de la divisa sobre la cual se va a realizar la conversion
        System.Console.Write("\ningrese el tipo de divisa al que desea utilizar:\n1. en-US\n2. es-ES\n3. ja-JP\n4. Salir del programa\n-> ");
        byte menu = Convert.ToByte(Console.ReadLine());

        // declaraciones de variables usadas en el switch
        double answer = 0;
        double tasa = 0;
        string culture_string = "";
        // swtich de los casos del menu

        switch (menu)
        {
          // pesos a dolares 
          case 1:
            culture_string = "en-US";
            tasa = 0.00025;
            answer = money * tasa;
            break;
          // pesos a euros
          case 2:
            culture_string = "es-ES";
            tasa = 0.00021;
            answer = money * tasa;
            break;
          case 3:
            culture_string = "ja-JP";
            tasa = 0.037;
            answer = money * tasa;
            break;
          case 4:
            System.Console.WriteLine("gracias por usar nuestro programa");
            validacion = false;
            return;
          default:
            System.Console.WriteLine("error, vuelva a intentarlo");
            // finalizar el programa en caso de que ingrese un valor invalido
            return;
        }   
        // definir el formato personalizado de la cultura elegida por el usario
        NumberFormatInfo nfi = new CultureInfo($"{culture_string}", false).NumberFormat;

        // separardor por defecto
        System.Console.Write("\nseparador por defecto: ");
        Console.WriteLine(answer.ToString("C", nfi));

        // separador personalizado con espacio
        nfi.CurrencyDecimalSeparator = " ";
        System.Console.Write("\nseparador con espacio: ");
        Console.WriteLine(answer.ToString("C", nfi));

        // 3 decimales de presicion
        System.Console.Write("\n3 decimales de separacion: ");
        Console.WriteLine($"{answer.ToString("C3", new CultureInfo($"{culture_string}"))}");
      } while (validacion == true);
    }
  }
}

