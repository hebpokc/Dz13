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
using System.Xml;
using Dz13.Classes;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Dz13
{
    public partial class MainForm : Form
    {
        private string filename;
        private Person[] peoples;
        public MainForm()
        {
            InitializeComponent();

            Init();
        }
        private void Init()
        {
            filename = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            peoples = null;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "XML файлы (*.xml)|*.xml| Json файлы (*.json)|*.json";
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                filename = opf.FileName;
                FileStream file = new FileStream(filename, FileMode.Open);

                if (Path.GetExtension(filename).ToLower() == ".xml")
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person[]), new[] { typeof(Student), typeof(Teacher) });
                    peoples = xmlSerializer.Deserialize(file) as Person[];
                }
                else if (Path.GetExtension(filename).ToLower() == ".json")
                {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Person[]), new[] { typeof(Student), typeof(Teacher) });
                    peoples = jsonSerializer.ReadObject(file) as Person[];
                }
                file.Close();
                MessageBox.Show("Файл загружен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {

            treeView.Nodes.Clear();

            TreeNode peoplesNode = new TreeNode("Люди");
            TreeNode studentsNode = new TreeNode("Ученики");
            TreeNode teachersNode = new TreeNode("Учителя");

            peoplesNode.Nodes.Add(studentsNode);
            peoplesNode.Nodes.Add(teachersNode);

            treeView.Nodes.Add(peoplesNode);

            for (int i = 0; i < peoples.Length; i++)
            {
                if (peoples[i] is Student)
                {
                    TreeNode studentNameNode = new TreeNode();
                    studentNameNode.Name = $"studentNameNode{i}";
                    studentNameNode.Text = $"{peoples[i].FullName.surname} {peoples[i].FullName.name} {peoples[i].FullName.patronymic}";
                    studentsNode.Nodes.Add(studentNameNode);
                }
                else
                {
                    TreeNode teacherNameNode = new TreeNode();
                    teacherNameNode.Name = $"teacherNameNode{i}";
                    teacherNameNode.Text = $"{peoples[i].FullName.surname} {peoples[i].FullName.name} {peoples[i].FullName.patronymic}";
                    teachersNode.Nodes.Add(teacherNameNode);
                }

                Label personNameLabel = new Label();
                personNameLabel.Name = $"patientFullNameLabel{i}";
                personNameLabel.Text = $"{peoples[i].FullName.surname} {peoples[i].FullName.name} {peoples[i].FullName.patronymic}";
                personNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                personNameLabel.Dock = DockStyle.Fill;
            }
        }
        private void peoplesTreeViewNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Info newInfo = new Info();
            newInfo.Show();
        }
    }
}
