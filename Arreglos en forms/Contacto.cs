using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

internal class Contacto : Persona
{
    private string telefono;
    private string correo;
    public string telefono_
    {
        get
        {
            return telefono;
        }
        set
        {
            telefono = telefono_;
            telefono = value.Replace(" ", "").Replace("-", "");
        }
    }

   
    
    public string Correo
   
        { get { return correo; }
        set { correo=value; }
        }
    public Contacto():base()
    {
        telefono = string.Empty;
        correo = string.Empty;
    }
    public Contacto(string nombre, DateTime fechaDenacimiento, string telefono) : base(nombre, fechaDenacimiento)
    {
        this.telefono = telefono;
        this.correo = correo;
    }

    public override string ToString()
    {
        return base.ToString() + " " + telefono + " "+ correo ;
    }
}
