using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bees_Bears
{
    internal class Hilos
    {
        public int Nabejas = 10;
        public int tarro = 0;
        public int salida = 0;
        public int numVeces = 3;
        int capTarro = 15;
        public int cont = 0;



        bool puedeComer = false,puedoProducir = true;

        public Hilos()
        {
            //son mas hilos pero hay que hacer funcionarlo con 3 xd
            Thread a1 = new Thread(Abejas);
            Thread a2 = new Thread(Abejas);
            Thread a3 = new Thread(Abejas);
            /*Thread a4 = new Thread(Abejas);
            Thread a5 = new Thread(Abejas);
            Thread a6 = new Thread(Abejas);
            Thread a7 = new Thread(Abejas);
            Thread a8 = new Thread(Abejas);
            Thread a9 = new Thread(Abejas);
            Thread a10 = new Thread(Abejas);*/

            Thread o = new Thread(Oso);

            a1.Start();
            a2.Start();
            a3.Start();
            /*a4.Start();
            a5.Start();
            a6.Start();
            a7.Start();
            a8.Start();
            a9.Start();
            a10.Start();*/

            o.Start();
        }

        public void Abejas()
        {
            while(cont<3)
            {
                while(puedoProducir==true&&puedeComer==false)
                {
                    Random rand = new Random();
                    //int miel = rand.Next(1, 4);

                    //Ya se lleno el tarro
                    if (tarro>=capTarro)
                    {
                        //Ya no puedo producir miel
                        puedoProducir=false;
                        puedeComer = true;
                        //espero a que se consuma el tarro
                        while (puedeComer == true)
                        {
                            if (cont == 3) break;
                        }
                        //si para este momento ya hice el ciclo 3 veces entonces ya termian
                        if (cont == 3) break;
                    }
                    else
                    {
                        //En caso de que algunos hilos aun esten ejecutandose fuera de la condicion no puedo producir miel
                        while(puedoProducir==false||puedeComer==true)
                        {

                        }
                        //if(cont == 3) break; tal vez pues un proceso puede quedarse aqui y sumar
                        int miel = rand.Next(1, 7);
                        tarro += miel;
                        Console.WriteLine("Abeja produce {0} tarro {1}", miel,tarro);
                    }
                }
            }
        }

        public void Oso()
        {
            while (true)
            {
                if (puedeComer == true)
                {
                    Console.WriteLine("Oso come tarro");
                    tarro = 0;
                    cont++;
                    if (cont == 3)
                        break;
                    puedeComer = false;
                    puedoProducir = true;
                }
            }
            salida++;
        }
    }
}
