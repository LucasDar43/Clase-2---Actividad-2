using System.Security.Cryptography.X509Certificates;

namespace actividad2 { 
class Program {
        static void Main(string[] args){

            Console.WriteLine("Bienvenido al programa para calcular áreas de círculos.");

            bool continuar = true;

            while (continuar){
                Console.WriteLine("Ingrese el radio del círculo: ");
                double radio;

                //validamos que lo que se ingrese sea un numero
                while (!double.TryParse(Console.ReadLine(), out radio))
                {
                    Console.WriteLine("Ingrese un valor numérico válido para el radio: ");
                }

                double area = Math.PI * Math.Pow(radio, 2); //== pi * (radio * radio)

                Console.WriteLine("El área del círculo es: " + area.ToString("0.000")); //limitamos decimales


                //Consulta nuevo ingreso
                bool respuestaValida = false;

                while (!respuestaValida){
                    Console.WriteLine("¿Desea calcular el área de otro círculo? (si/no)");
                    string respuesta = Console.ReadLine();

                //Excepcion si se ingresa respuesta != si o no
                    try
                    {
                        if (respuesta.ToLower() == "si") //toLower = convertimos todo a MINUSCULA y 
                        {                                //facilitamos el manejo de la variable
                            respuestaValida = true;
                        }
                        else if (respuesta.ToLower() == "no")
                        {
                            respuestaValida = true;
                            continuar = false;
                        }
                        else
                        {
                            throw new Exception("La respuesta debe ser 'si' o 'no'. Por favor, ingrese una respuesta válida.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            Console.WriteLine("\nGracias por utilizar el programa para calcular áreas de círculos. ¡Hasta luego!");

        //{main}
    }
    }
}