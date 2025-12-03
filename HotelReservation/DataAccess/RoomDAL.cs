using HotelReservation.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using HotelReservation.Models;
using Room = HotelReservation.Models.Room;

public class RoomDAL
{
    private readonly string _connectionString;

    public RoomDAL(string connectionString)
    {
        _connectionString = connectionString ;
    }

    // Insert a new room
    public bool AddRoom(Room room)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = @"
            INSERT INTO Rooms (RoomNo, Floor, RoomTypeId, PricePerNight, Description, Status)
            VALUES (@RoomNo, @Floor, @RoomTypeId, @PricePerNight, @Description, @Status)";

            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@RoomNo", room.RoomNo);
            cmd.Parameters.AddWithValue("@Floor", room.Floor);
            cmd.Parameters.AddWithValue("@RoomTypeId", room.RoomTypeId);
            cmd.Parameters.AddWithValue("@PricePerNight", room.PricePerNight);
            cmd.Parameters.AddWithValue("@Description", (object)room.Description ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", room.Status);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }


    // Update room
    public bool UpdateRoom(Room room)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = @"
                UPDATE Rooms 
                SET RoomNo=@RoomNo, Floor=@Floor, RoomTypeId=@RoomTypeId, 
                    PricePerNight=@PricePerNight, Description=@Description, Status=@Status
                WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Id", room.Id);
            cmd.Parameters.AddWithValue("@RoomNo", room.RoomNo);
            cmd.Parameters.AddWithValue("@Floor", room.Floor);
            cmd.Parameters.AddWithValue("@RoomTypeId", room.RoomTypeId);
            cmd.Parameters.AddWithValue("@PricePerNight", room.PricePerNight);
            cmd.Parameters.AddWithValue("@Description", (object)room.Description ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", room.Status);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // Get all rooms
    public DataTable GetRooms()
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Rooms";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }

    // Delete a room
    public bool DeleteRoom(int id)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Rooms WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public int GetRoomCount(int floor, int roomTypeId)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = @"SELECT COUNT(*) 
                         FROM Rooms 
                         WHERE Floor = @Floor AND RoomTypeId = @RoomTypeId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Floor", floor);
            cmd.Parameters.AddWithValue("@RoomTypeId", roomTypeId);

            conn.Open();
            return (int)cmd.ExecuteScalar();
        }
    }

}
