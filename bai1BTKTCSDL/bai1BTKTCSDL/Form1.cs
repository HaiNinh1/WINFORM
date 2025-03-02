using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1BTKTCSDL
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adding sample students
            ListSV.Instance.AddSinhVien(new Sinhvien("SV01", "Nguyen Van A", "Nam", "Hanoi", new DateTime(2001, 5, 12), "KTPM01", "CNTT"));
            ListSV.Instance.AddSinhVien(new Sinhvien("SV02", "Tran Thi B", "Nữ", "HCMC", new DateTime(2002, 8, 20), "KTPM02", "CNTT"));
            ListSV.Instance.AddSinhVien(new Sinhvien("SV03", "Le Van C", "Nam", "Da Nang", new DateTime(2000, 11, 5), "KTPM01", "CNTT"));

            // Bind data to DataGridView
            dataGridView1.DataSource = ListSV.Instance.GetSinhVienTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                // Get the student ID from the selected row
                string selectedMasv = dataGridView1.Rows[rowIndex].Cells["Mã SV"].Value.ToString();

                // Remove from ListSV
                ListSV.Instance.RemoveSinhVien(selectedMasv);

                // Remove from DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }
    }
}
