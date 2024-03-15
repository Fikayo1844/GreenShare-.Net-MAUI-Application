using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShare_Application.Data_models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ProfileImageURL { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public string PhoneNumber { get; set; }
        public int Rating { get; set; }
        public List<PlantListing> PlantsOwned { get; set; }
        public List<MessageCenter> MessagesReceived { get; set; }
    }
}
