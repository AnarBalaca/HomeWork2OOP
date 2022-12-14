namespace HomeWork2.Models
{
    public class User
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }

        public User(string name, string surename)
        {
            UserName = $"{name} {surename}".Trim().ToLower(); ;
            Email = EmailCreator(name, surename);

        }

        

        public string EmailCreator(string name, string sureName)
        {
            return this.Email = $"{name}{sureName}@code.edu.az".Trim().ToLower();
        }


    }
}
