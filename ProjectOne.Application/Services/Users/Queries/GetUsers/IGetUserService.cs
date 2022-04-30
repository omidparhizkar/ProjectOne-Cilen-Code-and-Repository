using System.Collections.Generic;

namespace ProjectOne.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUserService
    {
        ReslutGetUserDto Execute(RequestGetUserDto request);
    }
}