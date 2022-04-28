﻿
namespace Common.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string HashedPassword { get; set; }
    }
}
