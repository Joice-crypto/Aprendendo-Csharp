using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto()
        {

        }
        public string GetMarca()
        {
            // le a marca 
            return Marca;
        }
        public void SetMarca(string marca)
        {
            // seta a marca (quando quiser ter alguma mudança)
            Marca = marca;
        }
        public string GetModelo()
        {
            
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public int GetCilindrada()
        {

            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }

        

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("kawasaki", "lsldkds", 652);
            Console.WriteLine(moto1.GetCilindrada());
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());

            var moto2 = new Moto();
            moto2.SetCilindrada(-652);
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG");
            Console.WriteLine(moto2.GetCilindrada()+ " " + moto2.GetMarca() + " " + moto2.GetModelo());
        }
    }
}
