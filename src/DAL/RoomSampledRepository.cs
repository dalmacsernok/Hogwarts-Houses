using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.DAL
{
    public class RoomSampledRepository : IRepository<Room>
    {
        private RoomSampler _roomSampler { get; }

        public RoomSampledRepository()
        {
            _roomSampler = new RoomSampler();
        }

        public void Add(Room room)
        {
            _roomSampler.Add(room);
        }


        public Room Get(int id)
        {
            return _roomSampler.Get(id);
        }

        public HashSet<Room> GetAll()
        {
            return _roomSampler.GetAll();
        }

        public void Delete(int id)
        {
            _roomSampler.Delete(id);
        }

        public void Update(int id)
        {
            _roomSampler.Update(id);
        }

        public void AddStudent(Student student)
        {
            _roomSampler.AddStudent(student);
        }

        public HashSet<Student> GetAllStudents()
        {
            return _roomSampler.GetAllStudents();
        }

        public void AddStudentToRoom(int id, string name)
        {
            _roomSampler.AddStudentToRoom(id, name);
        }

        public IEnumerable<Room> GetAvailableRooms()
        {
            return _roomSampler.GetAvailableRooms();
        }

        public List<Room> GetRoomsWithSpecificPets()
        {
            return _roomSampler.GetRoomsWithSpecificPets();
        }
    }
}
