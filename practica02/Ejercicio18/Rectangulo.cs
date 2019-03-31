using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        /// <summary>
        /// Method  to build a Rectangulo with vertice1 and vertice3
        /// </summary>
        /// <param name="vertice1">Class Punto</param>
        /// <param name="vertice3">Class Punto</param>
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            int puntosX;
            int puntosY;

            //With vertice1 and vertice3 calculate the other vertices
            //using method Abs from Math
            puntosX = Math.Abs(vertice1.GetX() - vertice3.GetX());
            puntosY= Math.Abs(vertice1.GetY() - vertice3.GetY());

            //All vertices for the Rectangulo
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.GetX()+puntosX,vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(),vertice1.GetY() + puntosY);
        }

        /// <summary>
        /// Method to calculate Area of Rectangulo
        /// </summary>
        /// <returns>The Area</returns>
        public float Area()
        {
            float widthRectangulo;
            float heightRectangulo;
            widthRectangulo=CalcularWidthRectangulo();
            heightRectangulo=CalcularHeightRectangulo();
            this.area = widthRectangulo * heightRectangulo;

            return this.area;
        }

        /// <summary>
        /// Method to calculate Perimetro of Rectangulo
        /// </summary>
        /// <returns>The Rectangulo</returns>
        public float Perimetro()
        {
            float widthRectangulo;
            float heightRectangulo;
            widthRectangulo = CalcularWidthRectangulo();
            heightRectangulo = CalcularHeightRectangulo();
            this.perimetro = (widthRectangulo + heightRectangulo) * 2;
            return this.perimetro;
        }

        /// <summary>
        /// Calculate width of Rectangulo
        /// </summary>
        /// <returns>The width of rectangulo</returns>
        private float CalcularWidthRectangulo()
        {
            float widthRectangulo;
            widthRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
            return widthRectangulo;
        }

        /// <summary>
        /// Calculate height of Rectangulo
        /// </summary>
        /// <returns>The height of rectangulo</returns>
        private float CalcularHeightRectangulo()
        {
            float heightRectangulo;
            heightRectangulo = Math.Abs(vertice1.GetY() - vertice3.GetY());
            return heightRectangulo;
        }


        /// <summary>
        /// Method for show a message in string
        /// </summary>
        /// <param name="rectangulo">Class rectangulo</param>
        /// <returns>The message</returns>
        public static string ShowRectangulo(Rectangulo rectangulo)
        {
            StringBuilder infoRectangulo = new StringBuilder();
            string returnInfo;

            infoRectangulo.AppendFormat("Rectangulo > Ancho: {0} Alto: {1} Area: {2} Perimetro: {3}\n",rectangulo.CalcularWidthRectangulo()
                ,rectangulo.CalcularHeightRectangulo(),rectangulo.Area(),rectangulo.Perimetro());
            infoRectangulo.AppendLine("Vertice 1: \nX: " + rectangulo.vertice1.GetX() + "- Y: " + rectangulo.vertice1.GetY());
            infoRectangulo.AppendLine("Vertice 2: \nX: " + rectangulo.vertice2.GetX() + "- Y: " + rectangulo.vertice2.GetY());
            infoRectangulo.AppendLine("Vertice 3: \nX: " + rectangulo.vertice3.GetX() + "- Y: " + rectangulo.vertice3.GetY());
            infoRectangulo.AppendLine("Vertice 4: \nX: " + rectangulo.vertice4.GetX() + "- Y: " + rectangulo.vertice4.GetY());

            returnInfo = infoRectangulo.ToString();
            return returnInfo;
        }
    }
}
