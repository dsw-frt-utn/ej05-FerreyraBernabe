using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class Responsable
{
    private string nombre;
    private string documento;
    private string telefono;

    public Responsable(string nombre, string documento, string telefono)
    {
        this.nombre = nombre;
        this.documento = documento;
        this.telefono = telefono;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public string GetDocumento()
    {
        return documento;
    }

    public string GetTelefono()
    {
        return telefono;
    }
}
