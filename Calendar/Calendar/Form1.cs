using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Not ekleme formunu acmak icin buton tanimlandi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListele_Click(object sender, EventArgs e)
        {
            AddNote acAddNote = new AddNote();
            acAddNote.ShowDialog();
        }
        /// <summary>
        /// Form yuklendiginde arka planda calismasi icin NotifyIcon tannimlandi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            NotifyIcon iconum = new NotifyIcon();
            iconum.Icon = new Icon("C:\\Users\\inalf\\source\\repos\\Calendar\\icons\\calendar-clock-icon.ico");
            iconum.Visible = true;
            iconum.Text = "Calendar";
            iconum.MouseClick += delegate { AddNote _acAddNote = new AddNote();_acAddNote.ShowDialog(); };
        }
        /// <summary>
        /// Tarihte bugn yasanan olaylarin listelendigi formun acilmasi icin buton tanimlandi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            tarihteBugun trhBugun = new tarihteBugun();
            trhBugun.ShowDialog();
        }
        /// <summary>
        /// Formu kapatmak icin buton tanimlandi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}