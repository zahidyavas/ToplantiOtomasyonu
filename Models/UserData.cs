namespace ToplantiOtomasyonu.Models
{
    public static class UserData
    {
        private static List<UserInfo> users = new List<UserInfo>();

        static UserData()
        {
              users.Add(new UserInfo() { Name = "Enes", Email = "enesbilgili@example.com", Phone ="+90 555 343 2525", Attend = true});  
              users.Add(new UserInfo() { Name = "Kamer", Email = "kamerkurter@example.com", Phone ="+90 555 444 1414", Attend = true});
              users.Add(new UserInfo() { Name = "Akay", Email = "akayavkan@example.com", Phone ="+90 555 754 3636", Attend = true});  
              users.Add(new UserInfo() { Name = "İlker", Email = "ilkerkıran@example.com", Phone ="+90 555 985 5858", Attend = true});  
              users.Add(new UserInfo() { Name = "Hüseyin", Email = "hüseyinduran@example.com", Phone ="+90 555 415 9898", Attend = true});  
        }
        public static List<UserInfo> Users { 
            get { return users; } 
        }
        public static void CreateUser(UserInfo user)
        {
            users.Add(user);
        }
    }
}
