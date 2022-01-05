namespace ExemploConstrutores.Models
{
   public class Calculadora
    {
//delegate
public delegate void DelegateCalculadora();

//evento
public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
         {
             if (EventoCalculadora != null) // VERIFICA SE O EVENTO TEM INSCRITOS!!
             {
                 System.Console.WriteLine($"Adição: {x + y}");
                 EventoCalculadora(); //INVOCOU O EVENTO...E DEPOIS O METODO EventHandler que estava add nele
             }
             else
             {
                 System.Console.WriteLine(" Nenhum inscrito.");
             }
         }

        public static void Subtrair (int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}