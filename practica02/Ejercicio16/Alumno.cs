using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public string apellido;
        public int legajo;
        public string nombre;


        public  void CalcularFinal()
        {
            if(this.nota1>4 && this.nota2>4)
            {
                Random nota = new Random();
                this.notaFinal = nota.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }

        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            string retorno = "";
            retorno = "Nombre :" + this.nombre + "\nApellido:" + this.apellido + 
                "\nLegajo: " + this.legajo + "\nNota 1: "+ this.nota1+"\nNota 2: "+this.nota2;

            if(this.notaFinal==-1)
            {
                retorno += "\nNota Final: Alumno Desaporbado \n\n";
            }
            else
            {
                retorno += "\nNota Final:"+ this.notaFinal+ "\n\n";
            }
            return retorno;
        }


    }
}
