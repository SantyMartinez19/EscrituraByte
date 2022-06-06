using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraByte
{
    //Alumno: Santy Francisco Martinez Castellanos
    //No.Control: 21211989

    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = null;

            byte[] buffer = new byte[81];
            int nbytes = 0, car;
            

            try
            {
                //Crear el flujo del archivo 
                fs = new FileStream("texto.txt", FileMode.Create, FileAccess.Write);
                Console.WriteLine("Escriba el texto que desea almacenar en el archivo");

                while((car = Console.Read()) != '\r' && (nbytes < buffer.Length))
                { 
                 
                    buffer[nbytes] = (byte)car;
                    nbytes++;

                }

                fs.Write(buffer, 0, nbytes);


            }

            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }

            }


        }
    }
}
