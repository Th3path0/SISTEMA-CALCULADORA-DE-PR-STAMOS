using System;

namespace proyecto_final_prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            float balance, Capital, Cuota, Intereses, porcentaje_tasa_anual, porcentaje_tasa_mensual;
            int  fila, plazo, i;

            Console.Write("Introduzca el monto del prestamo: ");
            float.TryParse(Console.ReadLine(), out Intereses);
            Console.Write("Introduzca la tasa de porcentaje de interes anual: ");
            float.TryParse(Console.ReadLine(), out porcentaje_tasa_anual);
            Console.Write("Introduzca el plazo de pago en meses: ");
            int.TryParse(Console.ReadLine(), out plazo);
            

            //calcula el interes mensual
            porcentaje_tasa_mensual = (porcentaje_tasa_anual / 100) / 12;


            //Calcula la cuota mensual
            balance = porcentaje_tasa_mensual + 1;
            balance = (float)Math.Pow(balance, plazo);
            balance = balance - 1;
            balance = porcentaje_tasa_mensual / balance;
            balance = porcentaje_tasa_mensual + balance;
            balance = Intereses * balance;


            Console.WriteLine();
            fila = 1;
            Console.WriteLine();
            Console.Write("Numero de pago ");   
            Console.Write("\tCuota \t");
            Console.Write("\t Capital \t");
            Console.Write("Intereses\t");
            Console.Write("Balance \t\t");
            Console.WriteLine();
            Console.WriteLine();
   Console.WriteLine();
   Console.WriteLine();
   Console.WriteLine();
   Console.WriteLine();


            for (i = 1; i <= plazo; i++)
            {
//calculos a mostrar segun se cumpla el plazo
               Capital = porcentaje_tasa_mensual * Intereses;

                  Cuota = balance - Capital;

                   Intereses = Intereses - Cuota;
            //muestra los datos

                Console.Write("\t{0}\t", fila);

          

                Console.Write("{0}\t",Cuota);//cuota
               

                Console.Write("{0}\t",Capital);//capital

               
                Console.Write("{0}\t\t",Intereses);//intereses

                    
                Console.Write("{0}\t",balance); //balance


                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }

}
}
