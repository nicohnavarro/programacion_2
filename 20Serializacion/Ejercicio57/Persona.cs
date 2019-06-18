using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio57
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static bool Guardar(Persona person)
        {
            XmlTextWriter writer=null;
            XmlSerializer ser;
            
            writer = new XmlTextWriter(@"c:\ArchivoXML",UTF8Encoding.UTF8);
            ser = new XmlSerializer(typeof(Persona));
            ser.Serialize(writer, person);
            writer.Close();
            return true;
        }
        public static Persona Leer(string path)
        {
            XmlTextReader reader;
            XmlSerializer ser;
            Persona aux = new Persona();
            reader = new XmlTextReader(path);
            ser = new XmlSerializer(typeof(Persona));
            aux = (Persona)ser.Deserialize(reader);
            return aux;
        }
        public override string ToString()
        {
            return string.Format("Nombre: {0}\tApellido: {1}", this.nombre, this.apellido);
        }
    }
}
