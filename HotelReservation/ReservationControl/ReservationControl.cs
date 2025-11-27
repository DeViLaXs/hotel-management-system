using HotelReservation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation.roomControl
{
    public partial class ReservationControl : UserControl
    {
        public ReservationControl()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form AddReservationForm = new AddReservation();
            AddReservationForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form EditReservationForm = new EditReservation();
            EditReservationForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
