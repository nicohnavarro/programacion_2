using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1, MotoCross
        }
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        public List<T> VehiculosDeCompetencia { get {return this.competidores; } }
        public short CantidadCompetidores { get { return this.cantidadCompetidores; } set { this.cantidadCompetidores = value; } }
        public short CantidadVueltas { get {return this.cantidadVueltas; } set {this.cantidadVueltas=value; } }
        public VehiculoDeCarrera this[int i] { get { return competidores[i]; } }
        public TipoCompetencia Tipo { get {return this.tipo; } set {this.tipo=value; } }

        private Competencia()
        {
            competidores = new List<T>();
        }
        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo) : this()
        {
            this.CantidadVueltas = cantVueltas;
            this.CantidadCompetidores = cantCompetidores;
            this.Tipo = tipo;
        }
        public string MostrarDatos()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("Cantidad Competidores: {0}\n", this.CantidadCompetidores);
            sc.AppendFormat("Cantidad Vueltas: {0}\n", this.CantidadVueltas);
            sc.AppendFormat("Tipo de Competencia: {0}\n", this.Tipo);
            sc.AppendFormat("Competidor: {0}\n", this[0].MostrarDatos());

            return sc.ToString();
        }
        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera a)
        {
            return (!(c == a));
        }
        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            if (c.Tipo == TipoCompetencia.MotoCross && a is MotoCross)
            {
                retorno = true;
            }
            else if (c.tipo == TipoCompetencia.F1 && a is AutoF1)
            {
                retorno = true;
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Overload ==");
            }
            return retorno;
        }
        public static bool operator +(Competencia<T>c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            try
            {
                if (c == a)
                {
                    c.competidores.Add((T)a);
                    retorno = true;
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia Incorrecta", "Competencia", "Overload +", ex);
            }
            return retorno;
        }
        public static bool operator -(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            c.competidores.Remove((T)a);
            retorno = true;
            return retorno;
        }
    }
}
