using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void MovePanal(Control btn)
        {
            panalSlide.Top=btn.Top;
            panalSlide.Height=btn.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hi");
        }

        

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDash_Click(object sender, EventArgs e)
        {
            MovePanal(buttonDash);
            dashboardControl1.Show();
            reservationControl1.Hide();
            paymentControl1.Hide();
            roomControl1.Hide();
            clientControl1.Hide();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanal(buttonClient);
            dashboardControl1.Hide();
            reservationControl1.Hide();
            paymentControl1.Hide();
            roomControl1.Hide();
            clientControl1.Show();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanal(buttonReservation);
            dashboardControl1.Hide();
            reservationControl1.Show();
            paymentControl1.Hide();
            roomControl1.Hide();
            clientControl1.Hide();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanal(buttonRoom);
            dashboardControl1.Hide();
            reservationControl1.Hide();
            paymentControl1.Hide();
            roomControl1.Show();
            clientControl1.Hide();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            MovePanal(buttonPayment);
            dashboardControl1.Hide();
            reservationControl1.Hide();
            paymentControl1.Show();
            roomControl1.Hide();
            clientControl1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
