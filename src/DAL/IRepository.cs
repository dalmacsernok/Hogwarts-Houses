using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.DAL
{
    public interface IRepository<T>
    {
        public void Add(Room room);
        public Room Get(int id);
        public HashSet<Room> GetAll();
        public void Delete(int id);
        public void Update(int id);
        public void AddStudent(Student student);
        public HashSet<Student> GetAllStudents();
        public void AddStudentToRoom(int id, string name);
        public IEnumerable<Room> GetAvailableRooms();
        public List<Room> GetRoomsWithSpecificPets();
    }
}
