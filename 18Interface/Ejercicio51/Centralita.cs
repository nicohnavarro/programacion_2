using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    public class Centralita:IGuardar<string>
    {
        #region Centralita Atributtes
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Centralita Properties
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }
        #endregion

        #region Centralita Builders
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Centralita Methods
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada call in listaDeLlamadas)
            {
                if (tipo == TipoLlamada.Local && call is Local)
                {
                    Local localCall = (Local)call;
                    ganancia += localCall.CostoLlamada;
                }
                else if (tipo == TipoLlamada.Provincial && call is Provincial)
                {
                    Provincial provinCall = (Provincial)call;
                    ganancia += provinCall.CostoLlamada;
                }
                else if (tipo == TipoLlamada.Todas)
                {
                    if (call is Local)
                    {
                        Local localCall = (Local)call;
                        ganancia += localCall.CostoLlamada;
                    }
                    else if (call is Provincial)
                    {
                        Provincial provinCall = (Provincial)call;
                        ganancia += provinCall.CostoLlamada;
                    }
                }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendFormat("\nRazon Social: {0} \nGanancia Total: ${1}" +
                "\nGanancia por Llamados Locales: ${2} \nGanancia por Llamados Provinciales: ${3} \n-------------------------------------------------------" +
                "\nDetalles de Llamadas... \n-------------------------------------------------------\n"
                , razonSocial, GananciasPorTotal, GananciasPorLocal, GananciasPorProvincial);
            foreach (Llamada call in listaDeLlamadas)
            {
                mensaje.AppendFormat("{0}", call.Mostrar());
                mensaje.AppendLine("*******************************************************");
            }
            return mensaje.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort();
        }
        #endregion

        public bool Guardar()
        {

            return true;
        }
        public string Leer()
        {
            throw new NotImplementedException();
        }
        public string RutaDeArchivo
        {
            get
            {
                return "";
            }
            set
            {

            }
        }
    
    }
}
