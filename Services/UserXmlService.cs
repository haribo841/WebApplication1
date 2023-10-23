using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UserXmlService
    {
        private string dataFilePath = "users.xml";

        public List<User> ReadUsersFromXML()
        {
            List<User> users;
            if (File.Exists(dataFilePath))
            {
                using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    users = (List<User>)serializer.Deserialize(fileStream);
                }
            }
            else
            {
                users = new List<User>();
            }
            return users;
        }

        public void WriteUserToXML(User user)
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