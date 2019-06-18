using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.IO;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        //ESTO SE GUARDA EN \bin\Debug
        private const string PATH_TXT = @"c:\Local.xml";
        private string rutaArchivo;
        protected float costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public string RutaDeArchivo
        {
            get { return this.rutaArchivo; }
            set { this.rutaArchivo = value; }
        }

        private float CalcularCosto()
        {
            float costoTotal;
            costoTotal = costo * base.Duracion;
            return costoTotal;
        }

        public override bool Equals(object obj)
        {
            //return (obj.GetType() == typeof(Local));
            return obj is Local;
        }

        public Local ():base()
        {
            this.RutaDeArchivo = PATH_TXT;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.RutaDeArchivo = PATH_TXT;
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("{0}", base.Mostrar());
            sc.AppendFormat("Costo de Llamada : ${0}\n", this.CostoLlamada);
            return sc.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            XmlSerializer ser = null;
            XmlTextWriter writer;
            writer = new XmlTextWriter(RutaDeArchivo, Encoding.UTF8);
            ser = new XmlSerializer(typeof(Local));
            ser.Serialize(writer, this);
            writer.Close();
            return true;
        }

        public Local Leer()
        {
            Local retorno = null;
            if(File.Exists(RutaDeArchivo))
            {
                XmlTextReader reader = new XmlTextReader(RutaDeArchivo);
                XmlSerializer ser = new XmlSerializer(typeof(Local));
                Object obj = (Local)ser.Deserialize(reader);
                if(obj is Local)
                {
                    retorno = (Local)obj;
                }
                else
                {
                    throw new InvalidCastException();
                }
                reader.Close();
            }
            return retorno;
        }
    }
}
