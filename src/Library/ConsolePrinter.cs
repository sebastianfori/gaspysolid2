using System;
using System.Text;


namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// creamos una clase para separar la resṕonsabiloidad de separar la receta porque
    /// si el dia de mañana queremos cambiar como o donde se imprime lo cambiamos aqui
    /// </summary>
    public class ConsolePrinter
    {
         static public void PrintRecipe(string receta)
        {
            
            Console.WriteLine(receta);
          
        }
    }
}