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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public static BindingSource bindingSource;
        internal static List<Book> books;
        public string path = @"lib.xml";
        public static bool booln = false;
        public Form1()
        {
            InitializeComponent();
            
            books = File.Exists("lib.xml") ? DeserializeFromXML(@"lib.xml") : new List<Book>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = books;
            listBox1.DataSource = bindingSource;
            bindingSource.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("", "", "");
            form2.ShowDialog();
            string a = form2.textBox1.Text;
            string b = form2.textBox2.Text;
            string c = form2.textBox3.Text;
            if (booln)
            {
                books.Add(new Book(a, b, c));
                bindingSource.ResetBindings(true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index == -1) return;
            books.RemoveAt(index);
            bindingSource.ResetBindings(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index == -1) return;
            Form2 form2 = new Form2(books[index].Name, books[index].Author, books[index].Publisher);
            form2.ShowDialog();
            string a = form2.textBox1.Text;
            string b = form2.textBox2.Text;
            string c = form2.textBox3.Text;
            if (booln)
            {
                books[index] = new Book(a, b, c);
                bindingSource.ResetBindings(true);
            }       
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml files|*.xml";
            sfd.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SerializeToXML(books, Path.GetFullPath(sfd.FileName));
                path = sfd.FileName;
            }          
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files|*.xml";
            ofd.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            if (ofd.ShowDialog() == DialogResult.OK) {
                books = DeserializeFromXML(Path.GetFullPath(ofd.FileName));
                path = ofd.FileName;
                bindingSource.DataSource = books;
                bindingSource.ResetBindings(true);
            }          
        }
        private static void SerializeToXML(List<Book> lib, string path)
        {
            var serializer = new XmlSerializer(typeof(List<Book>));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, lib);
            textWriter.Close();
        }

        private static List<Book> DeserializeFromXML(string path)
        {
            var deserializer = new XmlSerializer(typeof(List<Book>));
            TextReader textReader = new StreamReader(path);
            var lib = (List<Book>)deserializer.Deserialize(textReader);
            textReader.Close();
            return lib;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializeToXML(books, Path.GetFullPath(path));
        }
    }
    public class Book
    {
        public Book() { }
        public Book(   
            string name,
            string author,
            string publisher)
        {       
            Name = name;
            Author = author;
            Publisher = publisher;
        }
        public string Name { get; set; }

        public string Author { get; set; }
        public string Publisher { get; set; }

        public override string ToString()
        {
            return string.Format("Название: {0}; Автор: {1}; Издательство: {2}", Name, Author, Publisher);
        }
    }
}
