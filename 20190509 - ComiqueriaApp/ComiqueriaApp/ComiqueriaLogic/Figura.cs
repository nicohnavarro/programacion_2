using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura:Producto
    {
        private double altura;
        public Figura(int stock,double precio,double altura):this(("Altura "+altura.ToString()+" cm"),stock,precio,altura)
        {

        }
        public Figura(string descripcion,int stock,double precio,double altura): base(descripcion, stock, precio)
        {
            this.altura = altura;
        }
        public override string ToString()
        {
            StringBuilder sc = new StringBuilder();
            sc.AppendFormat("{0}", base.ToString());
            sc.AppendFormat("Altura : {0}\n", this.altura);
            return sc.ToString();
        }
    }
}
