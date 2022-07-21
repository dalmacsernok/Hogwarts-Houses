using System.Collections.Generic;
using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;

namespace HogwartsHouses.Controllers
{
    [ApiController]
    public class RoomController : Controller
    {
        private RoomService _roomService;
        public RoomController(IRepository<Room> repository)
        {
            _roomService = new RoomService(repository);
        }

        [HttpGet]
        [Route("/rooms")]
        public HashSet<Room> GetAllRooms()
        {
            return _roomService.GetAllRooms();
        }

        [HttpPost]
        [Route("/rooms")]
        public void AddRoom([FromBody] Room room)
        {
            _roomService.AddRoom(room);
        }

        [HttpGet]
        [Route("/rooms/{id}")]
        public Room GetRoomById(int id)
        {
            return _roomService.GetRoom(id);
        }

        [HttpGet]
        [Route("/index")]
        public ActionResult Rooms()
        {
            var rooms = _roomService.GetAllRooms();
            ViewData["room"] = rooms;
            return View();
        }

        [HttpDelete]
        [Route("/rooms/{id}")]
        public void DeleteRoom(int id)
        {
            _roomService.DeleteRoom(id);
        }

        [HttpPut]
        [Route("/rooms/{id}")]
        public void UpdateRoom(int id)
        {
            _roomService.UpdateRoom(id);
        }

        [HttpPost]
        [Route("/students")]
        public void AddStudent(Student student)
        {
            _roomService.AddStudent(student);
        }

        [HttpGet]
        [Route("/students")]
        public HashSet<Student> GetAllStudents()
        {
            return _roomService.GetAllStudents();
        }

        [HttpPut]
        [Route("/students/{id}/{name}")]
        public void AddStudentToRoom(int id, string name)
        {
            _roomService.AddStudentToRoom(id, name);
        }

        [HttpGet]
        [Route("/rooms/available")]
        public IEnumerable<Room> GetAvailableRooms()
        {
            return _roomService.GetAvailableRooms();
        }

        [HttpGet]
        [Route("/rooms/rat-owners")]
        public List<Room> GetRoomsWithSpecificPets()
        {
            return _roomService.GetRoomsWithSpecificPets();
        }
    }
}

