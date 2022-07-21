using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.DAL
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public void AddRoom(Room room)
        {
            _repository.Add(room);
        }

        public Room GetRoom(int id)
        {
            return _repository.Get(id);
        }

        public HashSet<Room> GetAllRooms()
        {
            return _repository.GetAll();
        }

        public void DeleteRoom(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateRoom(int id)
        {
            _repository.Update(id);
        }

        public void AddStudent(Student student)
        {
            _repository.AddStudent(student);
        }

        public HashSet<Student> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }

        public void AddStudentToRoom(int id, string name)
        {
            _repository.AddStudentToRoom(id, name);
        }

        public IEnumerable<Room> GetAvailableRooms()
        {
            return _repository.GetAvailableRooms();
        }

        public List<Room> GetRoomsWithSpecificPets()
        {
            return _repository.GetRoomsWithSpecificPets();
        }
    }

}
