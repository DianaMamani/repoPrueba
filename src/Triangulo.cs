using System;
namespace Classes{
    public class Triangulo : FormaGeometrica
    {
        private int b;
        private int altura;
        public Triangulo(int e, int y){
            b = e;
            altura = y;
        }
        public override int calcularArea()
        {
           return b+altura;
        }
    }
}