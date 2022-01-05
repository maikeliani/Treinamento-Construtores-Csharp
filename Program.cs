using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {

         public delegate void Operacao ( int x, int y);
        static void Main(string[] args)        
        {

            

            Matematica m = new Matematica(10,20);
             m.Somar();

           // Operacao op = Calculadora.Somar;
            //Operacao op = new Operacao(Calculadora.Somar);
            //op += Calculadora.Subtrair ; 

            //op.Invoke (20,10); 

            
            //op(10,10);



            // const double pi= 3.14;
            // System.Console.WriteLine(pi);

            // Data data = new Data();
            
            // data.Mes = 10;

            // data.ApresentarMes();
            


            // Aluno p1 = new Aluno(" Maikel", " Iani", "matemática"); 
            // p1.Apresentar();           
            //Log log = Log.GetInstance(); // vai utilizar a instancia padrão
            // pra isso serve construtor privado, pra evitar instancia da sua classe
            
            // log.PropriedadeLog =  " Teste instancia";
            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            
            
        }
    }
}
