using System;
using System.Text;
namespace Desafio_Dirmod
{
    public static class Codificador
    {
                     

            public static string codificar (string texto) {
                string mensaje = "";
                string espacio="";
                char letra;
                string subcadena ;
                char[] caracteres = texto.ToCharArray();
                for (int i=0; i<caracteres.Length; i++){
                    letra=caracteres[i];
                    
                    subcadena = evaluarCaracter(letra);
                    if ((i+1)<caracteres.Length){
                        espacio= evaluarSiguiente(letra, caracteres[i+1]);
                    }
                                               
                    mensaje+=subcadena+espacio;
                   
                }
                return mensaje;
            }
            

          
           public static string evaluarSiguiente (char car1, char car2 ){
               //esta funcion evalua si el siguiente caracter corresponde a la misma tecla del caracter actual.
                //en caso de que eso ocurra, inserta un espacio correspondiente para indicar la pausa y el ingreso de la siguiente letra               
               string espacio="";
               int diferencia;
               Boolean ban=false;
               int codigo1 = (int) car1;
               int codigo2 = (int) car2;
               Console.WriteLine ("ASCII car1: "+codigo1 + " ASCII car2: "+codigo2);
               if (codigo1>=65 && codigo1<=90 && codigo2>=65 && codigo2<=90 ){
                    int min=65;
                    for (int max=67; max<=90; max+=3){
                        if (min==80 || min==87){
                            //min++;
                            max++;
                        }
                        ban= verificarMismaTecla(min, codigo1, codigo2, max);
                        if (ban){
                            espacio= " ";
                            break;
                        }
                        if (max==83 || max==90){
                            min++;
                        }
                                       
                        min+=3;
                    }

                }
                return espacio;
           }

            public static Boolean verificarMismaTecla(int min, int car1, int car2, int max){
                Boolean ban=false;
                if (car1>=min && car1<=max && car2>=min && car2<=max){
                    ban=true;
                }
                return ban;
            }
            public static string evaluarCaracter(char letra){
                string conversion ="";
               
                        switch (letra)
                        {
                            case 'A': 
                                conversion="2";
                                break;
                            case 'B': 
                                conversion="22";
                                break;
                            case 'C': 
                                conversion="222";
                                break;
                            case 'D': 
                                conversion="3";
                                break;   
                            case 'E': 
                                conversion="33";
                                break;
                            case 'F': 
                                conversion="333";
                                break;
                            case 'G': 
                                conversion="4";
                                break;
                            case 'H': 
                                conversion="44";
                                break;                            
                            case 'I':
                                conversion="444";
                                break;
                            case 'J':
                                conversion="5";
                                break;
                            case 'K':
                                conversion="55";
                                break;
                            case 'L':
                                conversion="555";
                                break;
                               case 'M':
                                conversion="6";
                                break;
                            case 'N':
                                conversion="66";
                                break;
                            case 'O':
                                conversion="666";
                                break;
                            case 'P':
                                conversion="7";
                                break;                            
                            case 'Q':
                                conversion="77";
                                break;
                            case 'R':
                                conversion="777";
                                break;
                            case 'S':
                                conversion="7777";
                                break;
                            case 'T':
                                conversion="8";
                                break;
                            case 'U':
                                conversion="88";
                                break;
                            case 'V':
                                conversion="888";
                                break;
                            case 'W':
                                conversion="9";
                                break;
                            case 'X':
                                conversion="99";
                                break;    
                             case 'Y':
                                conversion="999";
                                break;
                            case 'Z':
                                conversion="9999";
                                break;
                            //agregamos la conveccion de que si se ingreso un espacio se codifica a cero para diferenciar de las pausas de tecleo en la codificacion
                            case ' ':
                                conversion="0";
                                break;
                            default: 
                                conversion=letra.ToString();
                                break;                           
                        }

                return conversion;  
            }
                
    }
}
        
 
    
