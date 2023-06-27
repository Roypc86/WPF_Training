namespace WPFUI
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
