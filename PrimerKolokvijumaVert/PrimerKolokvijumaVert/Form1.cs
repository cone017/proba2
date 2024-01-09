using System;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using DataLayer.Models;

namespace PrimerKolokvijumaVert
{
    public partial class Form1 : Form
    {
        readonly VetsRepository vet = new VetsRepository();
        readonly VetBusiness vetB = new VetBusiness();
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            listBox1.Items.Clear();

            foreach (var i in vet.GetAllVets())
            {
                listBox1.Items.Add($"{i.FullName}, {i.YearsEperience}");
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Vet v = new Vet(textBoxFullName.Text, textBoxSpeciality.Text, Convert.ToInt32(textBox1.Text));

            vet.InsertVet(v);

            RefreshList();
            textBoxFullName.Text = string.Empty;
            textBoxSpeciality.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void buttonVise_Click(object sender, EventArgs e)
        {
            int broj = Convert.ToInt32(textBox2.Text);

            listBox1.Items.Clear();

            foreach (var i in vetB.GetAllVetsAboveValue(broj))
            {
                listBox1.Items.Add($"{i.FullName}, {i.YearsEperience}");
            }
        }
    }
}

