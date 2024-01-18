using Journal.models;
using System.ComponentModel;
using System.Text.Json;

namespace Journal
{
    public partial class Journal : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        public Journal()
        {
            InitializeComponent();

            try
            {
                var save = File.ReadAllText("./students.jnl");
                students = JsonSerializer.Deserialize<BindingList<Student>>(save)!;
            }
            catch
            {
                Console.WriteLine("Unable to read students.json");
            }

            studentInput.DataSource = new BindingSource(students, null);
            studentInput.DisplayMember = "FullName";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fullNameInput.Text))
            {
                var student = new Student()
                {
                    FullName = fullNameInput.Text,
                    Subjects = new Subjects()
                };
                students.Add(student);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(studentInput.Text))
            {
                students.Remove((Student) studentInput.SelectedItem!);
            }
        }

        private void marksGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var cell = marksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var color = default(Color);
            switch (cell.Value)
            {
                case 2: color = Color.OrangeRed; break;
                case 3: color = Color.Orange; break;
                case 4: color = Color.LightGreen; break;
                case 5: color = Color.SeaGreen; break;
                default: cell.Value = 2; break;
            }
            cell.Style.BackColor = color;
        }

        private void studentInput_SelectedValueChanged(object sender, EventArgs e)
        {
            var student = (Student)studentInput.SelectedItem!;
            if (student != null)
            {
                marksGridView.DataSource = new BindingSource(student.Subjects!, null);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dialog dialog = new Dialog();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.Yes)
            {
                var save = JsonSerializer.Serialize(students);
                File.WriteAllText("./students.jnl", save);
            }
        }
    }
}
