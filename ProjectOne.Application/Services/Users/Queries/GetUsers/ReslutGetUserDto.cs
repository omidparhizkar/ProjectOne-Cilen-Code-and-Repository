using System.Collections.Generic;

namespace ProjectOne.Application.Services.Users.Queries.GetUsers
{
    public class ReslutGetUserDto
    {
        public List<GetUserDto>Users { get; set; }
        public int Rows  { get; set; }
    }
}