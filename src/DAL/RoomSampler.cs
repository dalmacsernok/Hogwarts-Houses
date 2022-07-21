using System;
using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.DAL
{
    public class RoomSampler
    {
        public HashSet<Room> Rooms { get; }
        public HashSet<Student> Students { get; }

        public RoomSampler()
        {
            Rooms = new();
            Students = new();
        }

        public void Add(Room room)
        {
            Rooms.Add(room);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddStudentToRoom(int id, string name)
        {
            Get(id).AddStudents(Students.First(student => student.Name == name));
        }

        public HashSet<Student> GetAllStudents()
        {
            return Students;
            
        }

        public HashSet<Room> GetAll()
        {
            return Rooms;
        }

        public Room Get(int id)
        {
            return Rooms.First(room => room.Id == id);
        }

        public void Delete(int id)
        {
            Rooms.Remove(Rooms.First(room => room.Id == id));
        }

        public void Update(int id)
        {
            Rooms.First(room => room.Id == id).NeedRenovation = true;
        }

        public IEnumerable<Room> GetAvailableRooms()
        {
            return Rooms.Where(room => room.isAvailable is true);
        }

        public List<Room> GetRoomsWithSpecificPets()
        {
            List<Room> rooms = new();
            
            foreach (var room in Rooms)
            {
                bool isGood = true;
                foreach (var student in room.GetStudentsInRoom())
                {
                    if (student.Pet is PetType.Cat || student.Pet is PetType.Owl)
                    {
                        isGood = false;
                    }

                }

                if (isGood)
                {
                    rooms.Add(room);
                }

                
            }

            return rooms;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
