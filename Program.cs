using System;

namespace ola_mundo
{

    public class funcao{
        public string texto{get; set;}

        public string retorno(){
            string var1 = "fedcbA";
            char[] var2;

            var2 = var1.ToCharArray();

            for(int i =0; i<var1.Length; i++){
                Console.WriteLine("t "+var2[i]+" "+(int)var2[i] );
            }
            
            //Console.WriteLine("teste "+var2[1]);


            return "teste123";

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            funcao fnc = new funcao();

            fnc.retorno();

            Console.WriteLine("Hello World do Gilnelson!");
            Console.WriteLine("ola mundo");
        }
    }
}
