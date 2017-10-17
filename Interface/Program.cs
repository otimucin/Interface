using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone();
            iphone.Fiyat = 4000;
            iphone.Bilgiler();

            Console.WriteLine("----");

            Samsung samsung = new Samsung();
            samsung.Fiyat = 2000;
            samsung.Bilgiler();

            Console.ReadLine();

        }

        public interface ITelefonOzellikleri
        {
            string Marka { get; }
            string Model { get; }
            double Fiyat { get; set; }



            void Bilgiler();
        }


        public class Iphone : ITelefonOzellikleri
        {
            private string marka = "Iphone";
            private string model = "7";
            private double fiyat;

            public string Marka
            {
                
                get { return marka; }
            }

            public string Model
            {
                get { return model; }
            }

            public double Fiyat
            {
                get
                {
                    return fiyat;
                }
                set
                {
                    fiyat = value;
                }
            }


            public void Bilgiler()
            {
                Console.WriteLine("Marka : " + Marka);
                Console.WriteLine("Model : " + Model);
                Console.WriteLine("Fiyat : " + Fiyat);
            }
        }

       
        public class Samsung : ITelefonOzellikleri
        {
           
            private string marka = "Samsung";
            private string model = "Note5";
            private double fiyat;



            public string Marka
            {
                get
                {
                    return marka;
                }
            }

            public string Model
            {
                get
                {
                    return model;
                }
            }

            public double Fiyat
            {
                get
                {
                    return fiyat;
                }
                set
                {
                    fiyat = value;
                }
            }


            public void Bilgiler()
            {
                Console.WriteLine("Marka : " + Marka);
                Console.WriteLine("Model : " + Model);
                Console.WriteLine("Fiyat : " + Fiyat);
            }
        }
    }
}
