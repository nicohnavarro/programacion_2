using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace CentralitaHerencia
{
    public class Centralita:IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        //ESTO SE GUARDA EN \bin\Debug
        private const string PATH_TXT = @"c:\LogCentralita2.txt";
        private string rutaArchivo;
        public float GananciaPorLocal
        {
            get
            { return CalcularGanancia(TipoLlamada.Local); }
        }
        public float GananciaPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }
        public float GananciaPorTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        public string RutaDeArchivo { get { return this.rutaArchivo; } set { this.rutaArchivo = value; } }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (this != nuevaLlamada)
                listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada llamadaAux in this.listaDeLlamadas)
            {
                switch ((int)tipo)
                {
                    case 0:
                        if (llamadaAux is Local)
                        {
                            Local local = (Local)llamadaAux;
                            ganancia += local.CostoLlamada;
                        }
                        break;
                    case 1:
                        if (llamadaAux is Provincial)
                        {
                            Provincial provincial = (Provincial)llamadaAux;
                            ganancia += provincial.CostoLlamada;
                        }
                        break;
                    case 2:
                        if (llamadaAux is Local)
                        {
                            Local local = (Local)llamadaAux;
                            ganancia += local.CostoLlamada;
                        }
                        else if (llamadaAux is Provincial)
                        {
                            Provincial provincial = (Provincial)llamadaAux;
                            ganancia += provincial.CostoLlamada;
                        }
                        break;
                }
            }
            return ganancia;
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
            rutaArchivo = PATH_TXT;
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private string Mostrar()
        {
            return this.ToString();
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada llamadaAux in c.listaDeLlamadas)
            {
                if (llamadaAux == llamada)
                    retorno = true;
            }
            return retorno;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
             if (c == nuevaLlamada)
             {
                throw new CentralitaException("Exception capturada..", "mensaje2", "mensaje3");
             }
            else if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
                //c.Guardar(@"c:\Centralita.txt");
                if(nuevaLlamada is Local)
                {
                    Local nueva= (Local)nuevaLlamada;
                    nueva.Guardar();
                }
                if (!c.Guardar())
                {
                    throw new CentralitaException("FallaLogException", typeof(Centralita).Name, "+ Operator");
                }
            }


            return c;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("Nombre : {0}\n", this.razonSocial);
            sc.AppendFormat("Ganancia Total: ${0}\n", this.GananciaPorTotal);
            sc.AppendFormat("Ganancia Local: ${0}\n", this.GananciaPorLocal);
            sc.AppendFormat("Ganancia Provincial: ${0}\n", this.GananciaPorProvincial);
            sc.AppendLine();
            foreach (Llamada call in this.listaDeLlamadas)
            {
                if (call != null)
                {
                    sc.AppendFormat("{0}", call.ToString());
                    sc.AppendLine("***********");
                }
            }
            return sc.ToString();
        }

        public bool Guardar()
        {
            StreamWriter archivo = new StreamWriter(RutaDeArchivo, true);
            if (File.Exists(RutaDeArchivo))
            {
                archivo.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy H:mm") + " - Se realizo una llamada");
                archivo.Close();
                return true;
            }
            return false;
        }

        public string Leer()
        {
            if (File.Exists(RutaDeArchivo))
            {
                StreamReader archivo = new StreamReader(RutaDeArchivo);
                string texto = archivo.ReadToEnd();
                archivo.Close();
                return texto;
            }
            return "";
        }
    }
}
