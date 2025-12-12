using System;

namespace junpro_pradana
{
    // encapsulation dan abstraction
    public abstract class Developer
    {
        private string statusKontrak; 

        public string StatusKontrak 
        {
            get => statusKontrak;
            set => statusKontrak = value;
        }

        // ENCAPSULATION
        private int idDeveloper;
        private string namaDev;
        private string idProyek;
        private int fturSelesai;
        private int jumlahBug;
        private decimal skor;
        private decimal totalGaji;

        // Public Properties
        public int IdDeveloper
        {
            get => idDeveloper;
            set => idDeveloper = value;
        }

        public string NamaDev
        {
            get => namaDev;
            set => namaDev = value;
        }

        public string IdProyek
        {
            get => idProyek;
            set => idProyek = value;
        }

        public int FturSelesai
        {
            get => fturSelesai;
            set => fturSelesai = value;
        }

        public int JumlahBug
        {
            get => jumlahBug;
            set => jumlahBug = value;
        }

        public decimal Skor
        {
            get => skor;
            protected set => skor = value; // Protected agar child class bisa akses
        }

        public decimal TotalGaji
        {
            get => totalGaji;
            protected set => totalGaji = value;
        }

        // polymorph -> abstract yg harus diimplementasikan di child class
        public abstract void HitungSkor(decimal budget, int ftur);
        public abstract void HitungTotalGaji(decimal budgetProyek, int fturPokok, decimal skorPerforma);

        // Virtual (bisa di-override tapi tidak wajib)
        public virtual string GetStatusKontrak()
        {
            return "Developer";
        }
    }

    // inherintance: FreelanceDeveloper mewarisi dari Developer
    public class FreelanceDeveloper : Developer
    {
        // POLYMORPHISM: Override abstract method
        public override void HitungSkor(decimal budget, int ftur)
        {
            // Rumus Freelance: Skor = 10 × Fitur - 5 × Bug
            Skor = 10 * ftur - 5 * JumlahBug;
        }

        public override void HitungTotalGaji(decimal budgetProyek, int fturPokok, decimal skorPerforma)
        {
            decimal gajiDasar = budgetProyek * FturSelesai * skorPerforma / 100;

            if (skorPerforma >= 80)
                TotalGaji = gajiDasar;
            else if (skorPerforma >= 50)
                TotalGaji = gajiDasar * 0.8m;
            else
                TotalGaji = gajiDasar * 0.5m;
        }

        // Override virtual method
        public override string GetStatusKontrak()
        {
            return "Freelance";
        }
    }

    // inherit: FulltimeDeveloper mewarisi dari Developer
    public class FulltimeDeveloper : Developer
    {
        // polymorph: Override abstract method dengan implementasi berbeda
        public override void HitungSkor(decimal budget, int ftur)
        {
            // Rumus Fulltime: Skor = 100 × (1 - (2 × Bug) / (3 × Fitur))
            if (ftur == 0)
            {
                Skor = 0;
                return;
            }

            decimal pembilang = 2 * JumlahBug;
            decimal penyebut = 3 * ftur;
            Skor = 100 * (1 - (pembilang / penyebut));

            if (Skor < 0) Skor = 0;
        }

        public override void HitungTotalGaji(decimal budgetProyek, int fturPokok, decimal skorPerforma)
        {
            decimal gajiPokok = budgetProyek * fturPokok / 100;
            TotalGaji = gajiPokok + (gajiPokok * skorPerforma / 100);
        }

        public override string GetStatusKontrak()
        {
            return "Fulltime";
        }
    }
}