using HotelReservation.Forms;
using System;
using System.Data;
using HotelReservation.Models;
using Room = HotelReservation.Models.Room;

public class RoomService
{
    private readonly RoomDAL _roomDal;

    public RoomService(string connectionString)
    {
        _roomDal = new RoomDAL(connectionString);
    }

    public bool CreateRoom(Room room)
    {
        int floorNumber = room.Floor;          // get floor from passed Room
        int roomTypeId = room.RoomTypeId;      // get room type from passed Room

        // 1. Get how many rooms already exist on this floor & type
        int count = _roomDal.GetRoomCount(floorNumber, roomTypeId);

        // 2. Generate RoomNo: floor*100 + count+1 (e.g. 1*100 + 4 = 104)
        string roomNo = (floorNumber * 100 + (count + 1)).ToString();

        // 3. Update the Room object with generated values
        room.RoomNo = roomNo;
        room.Description = null;                     // no description
        room.Status = "Available";                   // default status

        // 4. Save to DB using DAL
        return _roomDal.AddRoom(room);
    }



    public DataTable GetAllRooms()
    {
        return _roomDal.GetRooms();
    }

    public bool UpdateRoom(Room room)
    {
        return _roomDal.UpdateRoom(room);
    }

    public bool DeleteRoom(int id)
    {
        return _roomDal.DeleteRoom(id);
    }
}
