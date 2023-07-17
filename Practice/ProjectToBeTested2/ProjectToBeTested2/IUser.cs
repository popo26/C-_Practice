namespace ProjectToBeTested2
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string DescribeMyFirstName();
        string DescribeMyFullName();
    }
}