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
        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [XmlElement("LastName")]
        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(150, ErrorMessage = "Last Name cannot exceed 150 characters")]
        public string Surname { get; set; }

        [XmlElement("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }

        [XmlElement("BirthDate")]
        [Required(ErrorMessage = "Birth Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        [BirthDateNotInFuture(ErrorMessage = "Date of Birth cannot be in the future")]
        public DateTime BirthDate { get; set; }

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

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
