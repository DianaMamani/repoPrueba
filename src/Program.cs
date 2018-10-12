using System;
using System.Collections.Generic;
using Classes;

namespace example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuad = new Cuadrado(3,2);
            Triangulo tri = new Triangulo(2,4);
            List<FormaGeometrica> formas = new List<FormaGeometrica>();
            formas.Add(cuad);
            formas.Add(tri);
            foreach(FormaGeometrica form in formas){
                Console.WriteLine("Area " + form.calcularArea());
            }
        }
    }
}
