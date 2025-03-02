using System;
using System.Collections.Generic;
using System.Data;

namespace bai1BTKTCSDL
{
    public class ListSV
    {
        private static ListSV instance;
        private List<Sinhvien> listSV;

        // Singleton Instance Property
        public static ListSV Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListSV();
                return instance;
            }
            set => instance = value;
        }

        // Private constructor to prevent external instantiation
        private ListSV()
        {
            listSV = new List<Sinhvien>();
        }

        // Property for accessing student list
        public List<Sinhvien> ListSVs { get => listSV; set => listSV = value; }

        // Add Student
        public void AddSinhVien(Sinhvien sv)
        {
            listSV.Add(sv);
        }

        // Remove Student by ID
        public bool RemoveSinhVien(string masv)
        {
            var student = listSV.Find(s => s.Masv == masv);
            if (student != null)
            {
                listSV.Remove(student);
                return true;
            }
            return false;
        }

        // Find Student by ID
        public Sinhvien FindSinhVien(string masv)
        {
            return listSV.Find(s => s.Masv == masv);
        }

        // Convert to DataTable for DataGridView
        public DataTable GetSinhVienTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã SV");
            table.Columns.Add("Họ tên");
            table.Columns.Add("Giới tính");
            table.Columns.Add("Quê quán");
            table.Columns.Add("Ngày sinh");
            table.Columns.Add("Lớp");
            table.Columns.Add("Khoa");

            foreach (Sinhvien sv in listSV)
            {
                table.Rows.Add(sv.Masv, sv.Hoten, sv.Gioitinh, sv.Quequan, sv.Ngaysinh.ToShortDateString(), sv.Lop, sv.Khoa);
            }

            return table;
        }
    }
}
