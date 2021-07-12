using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    public partial class MyInsertionSort : Component
    {
        public MyInsertionSort()
        {
            InitializeComponent();
        }

        public MyInsertionSort(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        /// <summary>
        /// Gelen verilerin sıralandıktan sonra saklanacağı dizi.
        /// </summary>
        private int[] dizi;
        /// <summary>
        /// Parametre olarak int türünde sayılar veya dizi alan ve gelen verileri sıralama metotuna gönderen metot.
        /// </summary>
        /// <param name="dizi"></param>
        public void Add(params int[] dizi)
        {
            insertion_sort(dizi);
        }
        /// <summary>
        /// Ekleme ( sıralama ) işlemi bittikten sonra sıralanmış verilerin çağıralacağı metot.
        /// </summary>
        /// <returns></returns>
        public int[] Cagir()
        {
            return this.dizi;
        }
        /// <summary>
        /// Add metotundan gelen verileri Insertion Sort algoritmasına göre sıralayan ve sıraladıktan sonra dizi adlı değişkene eşitleyen metot.
        /// </summary>
        /// <param name="dizi"></param>
        private void insertion_sort(int[] dizi)
        {
            // Insertion Sort Algoritması
            for (int j = 1; j < dizi.Length; j++)
            {
                int key = dizi[j];
                int i = j - 1;
                while (i >= 0 && dizi[i] > key)
                {
                    dizi[i + 1] = dizi[i];
                    i = i - 1;
                }
                dizi[i + 1] = key;
            }
            //Sıralanan dizi ilgili değişkene aktarılıyor.
            this.dizi = dizi;
        }
    }
}
