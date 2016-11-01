using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EjemploPersona;

namespace EjemploPersona
{
    public partial class _Default : Page
    {
        Persona2 p1;
        protected void Page_Load(object sender, EventArgs e)
        {
            p1 = new Persona2("David", 27, "M", "M", "dwaqdf");
        }

        protected void Formatear(object sender, EventArgs e)
        {
            p1.frase = Cadena.Text;
            Mostrar.Text = "Hola soy " + p1.nombre + "tengo " + p1.edad + "y mi frase es" + p1.frase; 
        }
    }
}