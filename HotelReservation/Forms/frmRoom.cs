using HotelReservation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Room = HotelReservation.Models.Room;


namespace HotelReservation.Forms
{
    public partial class frmRoom : Form
    {
        private readonly RoomService _roomService;
        string _connectionString = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString; 
        public frmRoom()
        {
            InitializeComponent();
            SeedRoomTypes();
            LoadRoomTypes();
            _roomService = new RoomService(_connectionString);

        }

        public void SeedRoomTypes()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Check if RoomTypes has data
                string checkQuery = "SELECT COUNT(*) FROM RoomTypes";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string insertQuery = @"
                INSERT INTO RoomTypes (Name) VALUES
                ('Single'),
                ('Double'),
                ('Suite')
                ";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadRoomTypes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name FROM RoomTypes"; // Change TypeName to your actual column name

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbType.DataSource = dt;
                cmbType.DisplayMember = "Name"; // what user sees
                cmbType.ValueMember = "Id";         // actual value bound to SelectedValue
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price field should not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFloor.Text))
            {
                MessageBox.Show("Floor field should not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFloor.Focus();
                return;
            }

            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Focus();
                return;
            }

            try
            {
                Room room = new Room();
                room.PricePerNight = decimal.Parse(txtPrice.Text);
                room.Floor = int.Parse(txtFloor.Text);
                room.RoomTypeId = Convert.ToInt32(cmbType.SelectedValue);

                // Generate room
                bool result = _roomService.CreateRoom(room);

                if (result)
                {
                    MessageBox.Show("Room added successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add room!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Price and Floor.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
