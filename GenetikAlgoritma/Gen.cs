//McCormick Fonksiyonu
//Formül: sin(x+y) + (x+y)^2 - 1.5x + 2.5y +1
//Limitler: -1.5 <= x <= 4  &&  -3 <= y <= 4
//Ramazan Mutlu
namespace GenetikAlgoritma
{
    class Gen
    {
        public double value;
        double max,min;

        public Gen() { }

        public Gen(double min, double max)  //Gen değeri için minimum ve maksimum aralığını alan constructor.
        {
            this.max = max;
            this.min = min;
            RandomizeValue();   //Constructor çalıştığında Rastgele bir değer üretiliyor.
        }

        public Gen(double value)
        {
            this.value = value;
        }

        private void RandomizeValue()   //Verilen aralıklarda rastgele değer üreten fonksiyon.
        {
            value = (AI.rand.NextDouble() * (max - min)) + min;
        }

        public void Mutate()    
        {
            if (AI.rand.NextDouble() < AI.mutationRate)    //Eğer rastgele üretilen sayı mutasyon değerinin altındaysa bu Gen'in değerini yeniden oluştur.
                RandomizeValue();
        }
        
    }
}
