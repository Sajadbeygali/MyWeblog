using System.ComponentModel.DataAnnotations;

namespace MyWeblog.Models
{
    public class User
    {
        public User(Guid Id, string firtName, string email,string userName, string password)
        {
            Id = Guid.NewGuid();
            this.FirtName = FirtName;
            this.UserName = UserName;
            this.Email = Email;
            this.Password = Password;
            this.OTPcode = GenrateOTP();
        }
        public Guid Id { get; set; }
        public string FirtName { get; private set; }
        public string UserName { get; set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string OTPcode { get; set; }

        //public User(string Email, string Password)
        //{
        //    this.Email = Email;
        //    this.Password = Password;
        //}
        public string GenrateOTP()
        {
            OTPcode = Guid.NewGuid().ToString().Substring(0,5);
            return OTPcode;

        }
        private User() { }



    }
}
