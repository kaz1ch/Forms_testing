using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Forms_testing.Service;
using Forms_testing.Models;

namespace Forms_testing
{
    public partial class MainForm : Form
    {
        private readonly List<Student> _Students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenStudentsDBMenuItem_OnClick(object sender, EventArgs e)
        {
            StudentsDBOpenFileDialog.InitialDirectory = Environment.CurrentDirectory;

            var dialog_result = StudentsDBOpenFileDialog.ShowDialog();
            if (dialog_result != DialogResult.OK) return;

            var data_file_name = StudentsDBOpenFileDialog.FileName;

            if (!File.Exists(data_file_name))
            {
                MessageBox.Show("Выбранный файл не существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var reader = File.OpenText(data_file_name))
            {
                var students = Extensions.ReadStudents(reader);

                _Students.Clear();
                _Students.AddRange(students);
            }

            StudentsList.Items.Clear();
            foreach (var student in _Students)
                StudentsList.Items.Add(student.LastName + " " + student.Name + " " + student.Patronymic)
        }
    }
}
