using System;
using System.Threading.Tasks;
using System.IO;

namespace Desafio_Dirmod
{
    public static class Log
    {
         


         public static async Task logThis(String texto, String conversion){
           await Task.Run(()=> File.AppendAllText("Log.txt", $" {DateTime.Now} \n Texto: {texto} \n conversion: {conversion} \n"));
                
         } 
    }
           
                  
    
}