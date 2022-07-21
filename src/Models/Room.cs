using System;
using System.Collections.Generic;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        public int Id { get; }
        private int _capacity  { get; }
        public bool NeedRenovation { get; set; }
        private HashSet<Student> _students;
        public bool isAvailable => _students.Count < _capacity;

        public Room(int id)
        {
            Id = id;
            _capacity = 5;
            NeedRenovation = false;
            _students = new();
        }

        public void AddStudents(Student student)
        {
            if (_students.Count < _capacity)
            {
                _students.Add(student);
            }
            else
            {
                Console.WriteLine("Sorry, this room has no available bed left!");
            }
        }

        public HashSet<Student> GetStudentsInRoom()
        {
            return _students;
        }
    }
}
