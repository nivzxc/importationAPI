namespace Importation.Model
{
    public class UserAccount
    {
        public int UserID { get; set; }
        public string UserLoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Admin { get; set; }
        public int Officer { get; set; }
        public int LoginStatus { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime RecordTime { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
