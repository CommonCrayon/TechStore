namespace Store.Structs
{
    public struct UserData
    {
        public UserRoles UserRole;
        public string UserId;
        public string UserName;
        public string Password;
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;

        public UserData(int role, string id, string userName, string password, string first, string last, string email, string phone)
        {
            UserRole = (UserRoles)Enum.ToObject(typeof(UserRoles), role);
            UserId = id;
            UserName = userName;
            Password = password;
            FirstName = first;
            LastName = last;
            Email = email;
            PhoneNumber = phone;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(UserId) && string.IsNullOrEmpty(UserName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
