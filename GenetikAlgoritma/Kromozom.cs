using System;
//McCormick Fonksiyonu
//Formül: sin(x+y) + (x-y)^2 - 1.5x + 2.5y +1
//Limitler: -1.5 <= x <= 4  &&  -3 <= y <= 4
//Ramazan Mutlu
namespace GenetikAlgoritma
{
    class Kromozom
    {
        public Gen[] genes = new Gen[2];
        public Kromozom()   //Kromozomları otomatik oluşturan bir constructor oluşturdum.
        {
            genes[0] = new Gen(-1.5, 4);    //Problemde verilen limit değerlerini minimum ve maksimum olarak girdim.
            genes[1] = new Gen(-3, 4);
        }

        public Kromozom(Gen g1, Gen g2) //Her kromozom için iki tane gen alan bir constructor oluşturdum.
        {
            genes[0] = g1;  
            genes[1] = g2;
        }

        public double Function()    //Problemin sonucunu döndüren fonksiyon.
        {
            double x = genes[0].value;
            double y = genes[1].value;
            return Math.Sin(x + y) + Math.Pow((x - y), 2) - (1.5 * x) + (2.5 * y) + 1;
        }

        public void Mutate()    //Kromozomun genlerini mutasyona uğratan fonksiyon.
        {
            genes[0].Mutate();
            genes[1].Mutate();
        }

        public static Kromozom operator *(Kromozom k1,Kromozom k2)  //Çaprazlama(Crossover) işlemini * operatörüne atadım.
        {
            Kromozom retVal = k1;
            for(int i=0;i<2;i++)
                if (AI.rand.NextDouble() < AI.crossoverRate) {  //Eğer rastgele gelen değer crossover oranının altındaysa crossover işlemine tabi tuttum.
                    double coRate = AI.rand.NextDouble();
                    retVal.genes[i].value = (coRate * k1.genes[i].value) + ((1 - coRate) * k2.genes[i].value); 
                }
            return retVal;
        }

    }
}
