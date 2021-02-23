namespace ConnectTerminal.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public bool Active { get; set; }
    }
}