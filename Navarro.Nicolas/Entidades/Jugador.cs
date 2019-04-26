using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        public Jugador(string nombre,string apellido,int edad,int dni,float peso,float altura,Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        public override string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendFormat("{0}",base.Mostrar());
            informacion.AppendFormat("Altura: {0}",this.Altura);
            informacion.AppendFormat("Peso: {0}", this.Peso);
            informacion.AppendFormat("Posicion: {0}", this.Posicion);

            return informacion.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            float imc;
            bool retorno = false;
            imc = this.Peso / (this.Altura*this.Altura);
            if(imc>=18.5f && imc<=25)
            {
                retorno = true;
            }
            return retorno;
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(base.Edad<40 && ValidarEstadoFisico())
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
