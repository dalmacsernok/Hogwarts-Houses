using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        public string Name { get; }
        public PetType Pet { get; }
        public HouseType House { get; }

        public Student(string name, PetType pet, HouseType house)
        {
            Name = name;
            Pet = pet;
            House = house;
        }
    }
}
