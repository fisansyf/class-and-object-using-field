using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class car
    {
        //field
        private string _warna;
        private int _jumlahpintu;
        private string _merk;
        private string _model;
        private int _tahunkeluar;

        //properties
        public string Warna 
        {
            get
            {
                return _warna;
            }
            set
            {
                _warna = value;
            }
        }
        public int JumlahPintu
        {
            get 
            { 
                return _jumlahpintu; 
            }
            set 
            {
                _jumlahpintu = value;
            }
        }
        public string Merk
        {
            get
            {
                return _merk;
            }
            set
            {
                _merk = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int TahunKeluar
        {
            get
            {
                return _tahunkeluar;
            }
            set
            {
                _tahunkeluar = value;
            }
        }

        //method
        public void Gas(int kecepatan)
        {
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}", _model, kecepatan);
        }
        public void Klakson(string suara)
        {
            Console.WriteLine("suara klakson {0}", suara);
        }

        public void Tampilkaninfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merk {1}, model {2}, keluaran tahun {3}, dengan jumlah pintu {4}", _warna, _merk, _model, _tahunkeluar, _jumlahpintu);
        }
    }
}
