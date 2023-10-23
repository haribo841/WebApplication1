using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WebApplication1.Models
{
    [Serializable]
    [XmlRoot("User")]
    public class User
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("FirstName")]
        public required string Name { get; set; }
        [XmlElement("LastName")]
        public required string Surname { get; set; }
        [XmlElement("Gender")]
        public required string Gender { get; set; }
        [XmlElement("BirthDate")]
        public required DateTime BirthDate { get; set; }
        [XmlElement("TelephoneNumber")]
        public int? TelephoneNumber { get; set; }
        [XmlElement("Position")]
        public string? Position { get; set; }
        [XmlElement("ShoeSize")]
        public int? ShoeSize { get; set; }
        public User()
        {

        }
    }
}
