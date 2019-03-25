using System;
using System.Collections.Generic;
using System.Linq;

//McCormick Fonksiyonu
//Formül: sin(x+y) + (x-y)^2 - 1.5x + 2.5y +1
//Limitler: -1.5 <= x <= 4  &&  -3 <= y <= 4
//Ramazan Mutlu

namespace GenetikAlgoritma
{
    class AI
    {
        public static Random rand = new Random();   //Tüm rastgelelik işlemlerinde kullanılmak üzere statik Random nesnesi.

        public static double mutationRate=0.1, crossoverRate=0.1;   
        public static double eliteCount = 4;
        private int populationSize=20;

        public List<Kromozom> population = new List<Kromozom>();    //Popülasyonu ve Elitleri tutacak listeler tanımlandı.
        public List<Kromozom> elites=new List<Kromozom>();

        public AI(int size) {
            InitPopulation(size);   //Constructor çağırıldığında ilk popülasyon oluşturuluyor.
        }

        private void InitPopulation(int size)
        {
            populationSize = size;
            population = new List<Kromozom>();
            for (int i = 0; i < size; i++)
            {
                population.Add(new Kromozom()); //Popülasyon genişliği kadar rastgele gen üretildi.
            }
            MutatePopulation(); //Popülasyon mutasyona sokuldu.
            CrossoverPopulation();  //Popülasyon çaprazlamaya sokuldu.
        }

        public void Iterate()
        {
            population.Clear(); //Her iterasyonda popülasyon tamamen siliniyor
            population.AddRange(elites);    //Elitler ayrı bir listede tutulup temizlenmiş popülasyona ekleniyor.
            for (int i = 0; i < populationSize-elites.Count; i++)
            {
                population.Add(new Kromozom()); //Elitler dışındaki Kromozomlar yeniden üretiliyor.
            }
            MutatePopulation(); //Popülasyon mutasyona sokuldu.
            CrossoverPopulation();  //Popülasyon çaprazlamaya sokuldu.
            SelectElites(); //Elitler seçildi.
        }

        private void MutatePopulation() {   //Popülsayondaki tüm kromozomların Mutasyon fonksiyonunu çağırır.
            foreach (Kromozom k in population)
                k.Mutate();
        }
        private void CrossoverPopulation()     //Popülasyondaki kromozomları karıştırıp, her birini bir sonrakiyle çaprazlayan fonksiyon.
        {
            Shuffle(population);
            for(int i = 0; i < population.Count-1; i++)
            {
                population[i] = population[i] * population[i + 1];
            }
        }
        private void SelectElites() //Elitleri seçen fonksiyon.
        {
            elites.Clear(); //Önceki elitler listesi temizlendi.
            List<Kromozom> sorted = population.OrderBy((Kromozom k) => k.Function()).ToList();  //Popülasyondaki kromozomlar formül sonucuna göre küçükten büyüğe sıralandı.
            for (int i = 0; i < AI.eliteCount; i++) //Kaç tane elit seçilecekse popülasyondaki en küçük o kadar kromozom elitler listesine eklenir.
                elites.Add(sorted[i]);
        }









        public void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = AI.rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
