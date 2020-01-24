using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Properties

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Height.
        /// </summary>
        public double Height { get; set; }

        #endregion 

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="name"> Name. </param>
        /// <param name="gender"> Gender. </param>
        /// <param name="birthDate"> Date of birth. </param>
        /// <param name="weight"> Weight. </param>
        /// <param name="height"> Height. </param>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {

            #region Conditional test

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("The user name cannot be empty or null.", nameof(name));

            if (gender == null)
                throw new ArgumentNullException("The gender cannot be null.", nameof(gender));

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
                throw new ArgumentException("Incorrect birthday date.", nameof(birthDate));

            if (weight <= 0)
                throw new ArgumentException("Incorrect weight.", nameof(weight));

            if (height <= 0)
                throw new ArgumentException("Incorrect height.", nameof(height));

            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
