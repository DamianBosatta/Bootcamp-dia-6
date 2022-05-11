using System;
using System.Collections.Generic;
using System.Text;

public class Persona
{
    string nombre;
    int edad;
    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }


}
