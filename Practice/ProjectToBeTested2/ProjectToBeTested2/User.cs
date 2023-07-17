

namespace ProjectToBeTested2
{
    public class User: IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User(string firstName)
        {
            FirstName = firstName;
        }

        public User() { }

        /// <summary>
        ///  DescribeMyFullName() method
        /// </summary>
        /// <return>Full Name</return>
        public string DescribeMyFullName()
        {
            return String.Format("My name is " + FirstName + " " + LastName);
            
        }

        /// <summary>
        ///  DescribeMyFirstName() method
        /// </summary>
        /// <return>First Name</return>
        public string DescribeMyFirstName()
        {
            return String.Format("My name is " + FirstName);

        }
    }
}
