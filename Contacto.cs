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

internal class Contactos : Persona
{
    private string Telefono;
    private string _correo;
    public string _telefono
    {
        get
        {
            return _telefono;
        }
        set
        {
            Telefono = _telefono;
            Telefono = value.Replace(" ", "").Replace("-", "");
        }
    }

   
    
    public string Correo
   
        { get { return _correo; }
        set { _correo=value; }
        }
    public Contactos():base()
    {
        Telefono = string.Empty;
        _correo = string.Empty;
    }
    public Contactos(string nombre, DateTime fechaDenacimiento, string Telefono) : base(nombre, fechaDenacimiento)
    {
        this.Telefono = Telefono;
        this._correo = _correo;
    }

    public override string ToString()
    {
        return base.ToString() + " " + Telefono + " "+ _correo ;
    }
}
