using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogBook.VO;

namespace LogBook.View
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Objeto
            Student student = new Student();
            student.studentName = txtName.Text;
            student.ar = txtAr.Text;
            student.classCode = txtClassCode.Text;
            student.miniCurriculum = txtMiniCurriculum.Text;
            student.hobby = txtHobby.Text;
            MessageBox.Show(student.studentName);
        }
    }
}
