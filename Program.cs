﻿using System;
using CoreEscuela.Entidades;
namespace CoreEscuela
{
   

    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Liceo", 2010);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Sincelejo";
            Console.WriteLine(escuela.Nombre);
        }
    }
}
