using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1BTKTCSDL
{
    public class Sinhvien
    {
        private string masv;
        private string hoten;
        private string gioitinh;
        private string quequan;
        private DateTime ngaysinh;
        private string lop;
        private string khoa;

        // Constructor
        public Sinhvien(string masv, string hoten, string gioitinh, string quequan, DateTime ngaysinh, string lop, string khoa)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.quequan = quequan;
            this.ngaysinh = ngaysinh;
            this.lop = lop;
            this.khoa = khoa;
        }

        // Properties (Getters and Setters)
        public string Masv { get => masv; set => masv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Khoa { get => khoa; set => khoa = value; }

        // Override ToString for better display
        public override string ToString()
        {
            return $"{Masv} - {Hoten} - {Gioitinh} - {Quequan} - {Ngaysinh.ToShortDateString()} - {Lop} - {Khoa}";
        }
    }
}
