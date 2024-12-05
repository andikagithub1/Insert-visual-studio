using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertStudentApp
{
    public partial class Form1 : Form
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
            try
            {
                using (var db = new StudentDB1Entities())
                {
                    // Membuat objek baru dari stTable dan memasukkan data dari TextBox
                    var newStudent = new stTable
                    {
                        StdName = textBox1.Text,
                        FirstName = textBox2.Text,
                        LastName = textBox3.Text
                    };

                    // Menambahkan objek baru ke DbSet
                    db.stTables.Add(newStudent);

                    // Menyimpan perubahan ke database
                    db.SaveChanges();

                    // Memberikan pesan sukses
                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Bersihkan TextBox setelah data disimpan
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                // Menangani error
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDB1DataSet.stTables' table. You can move, or remove it, as needed.
            this.stTablesTableAdapter.Fill(this.studentDB1DataSet.stTables);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
