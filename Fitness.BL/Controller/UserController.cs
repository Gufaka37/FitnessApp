using Fitness.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.BL.Controller
{
    /// <summary>
    /// User controller.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// The user of the application.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Create new user controller.
        /// </summary>
        /// <param name="userName"> Name. </param>
        /// <param name="genderName"> Gender. </param>
        /// <param name="birthDay"> Date of birth. </param>
        /// <param name="weight"> Weight. </param>
        /// <param name="height"> Height. </param>
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {

            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);            
        }

        /// <summary>
        /// Save user data.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        /// <summary>
        /// Receive user data.
        /// </summary>        
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }                
            }
        }
    }
}
