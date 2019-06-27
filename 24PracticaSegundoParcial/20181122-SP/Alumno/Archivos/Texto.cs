using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string tabla, Queue<Patente> datos)
        {
            StreamWriter sw = new StreamWriter("archivo.txt", true);
            try
            {

                foreach(Patente patenteAux in datos)
                {
                    sw.WriteLine(patenteAux.CodigoPatente);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                sw.Close();
            }  
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            Patente patente=new Patente();
            StreamReader sr = new StreamReader(tabla);
            while(!sr.EndOfStream)
            {
                patente.CodigoPatente=sr.ReadLine();
                
            }
        }
    }
}
