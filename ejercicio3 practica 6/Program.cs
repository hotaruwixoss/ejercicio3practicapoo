using System;

namespace ejercicio3_practica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            C objmensaje = new C();

        }
    }

    class A
    {
        public string mensajeA;
        public A()
        {
           mensajeA = "Hola, este es programa que muestra mensajes.";
        }
    }

    class B : A
    {
        public string mensajeB;
        public B()
        {
          mensajeB = "Jesucristo es el mismo ayer, hoy y por los siglos.";
        }

    }

    class C : B
    {
        public string mensajeC;
        public C()
        {
          mensajeC = "Sonrie ante los retos de la vida. ";
        }
    }
}
