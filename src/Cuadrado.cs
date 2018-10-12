using System;
namespace Classes{
    public class Cuadrado : FormaGeometrica
    {
        private int lado1;
        private int lado2;
        public Cuadrado(int x , int y){
            lado1= x;
            lado2 = y;
        }
        public override int calcularArea(){
            return lado1 * lado2;
        }
    }
}