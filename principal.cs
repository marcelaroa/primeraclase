using System;
using LibreriaClases;

namespace principal {

    class programaPrincipal{
        static void Main(){

            string nombre;
            nombre = "juan";

            perro firulai;

            firulai = new perro();

            perro pedro = new perro();

            Console.WriteLine("hola");

           firulai.edad = 2;

           firulai.tamano = "grande";

           firulai.raza = "caniche";

           firulai.jugar("saltar");
           firulai.jugar("dormirse");

           Console.WriteLine(firulai.ladrar());
        }
    }
}