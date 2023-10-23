using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private string dataFilePath = "users.xml";

        public IActionResult Index()
        {
            List<User> users = ReadUsersFromXML();
            return View(users);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            WriteUserToXML(user);
            return RedirectToAction("Index");
        }

        private List<User> ReadUsersFromXML()
        {
            List<User> users;
            using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                users = (List<User>)serializer.Deserialize(fileStream);
            }
            return users;
        }

        private void WriteUserToXML(User user)
        {
            List<User> users = ReadUsersFromXML();
            users.Add(user);

            using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(fileStream, users);
            }
        }
    }
}
