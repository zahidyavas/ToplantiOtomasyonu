namespace ToplantiOtomasyonu.Models
{
    public static class UserData
    {
        private static List<UserInfo> users = new List<UserInfo>();

        static UserData()
        {
              users.Add(new UserInfo() { Id = 1, Name = "Kamer Kurter", Email = "kamerkurter@example.com", Phone ="+90 555 444 1414", Attend = true});
              users.Add(new UserInfo() { Id = 2, Name = "Enes Bilgili", Email = "enesbilgili@example.com", Phone ="+90 555 343 2525", Attend = true});  
              users.Add(new UserInfo() { Id = 3, Name = "Akay Avkan", Email = "akayavkan@example.com", Phone ="+90 555 754 3636", Attend = false});  
              users.Add(new UserInfo() { Id = 4, Name = "İlker Kıran", Email = "ilkerkıran@example.com", Phone ="+90 555 985 5858", Attend = true});  
              users.Add(new UserInfo() { Id = 5, Name = "Hüseyin Duran", Email = "hüseyinduran@example.com", Phone ="+90 555 415 9898", Attend = true});  
        }
        public static List<UserInfo> Users { 
            get { return users; } 
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
    }
}
