using System.Collections.Generic;
using System.Linq;
using ProjectOne.Application.Interfaces.Contexts;
using ProjectOne.Common;

namespace ProjectOne.Application.Services.Users.Queries.GetUsers
{
    public class GetUserService : IGetUserService
    {
        private readonly IDatBaseContext _context;

        public GetUserService(IDatBaseContext context)
        {
            _context = context;
        }
        public ReslutGetUserDto  Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }

            int rowsCount = 0;
            var userList= users.ToPaged(request.Page,20,out rowsCount).Select(p=>new GetUserDto
            {
                Email = p.Email,
                FullName = p.FullName,
            }).ToList();


            return new ReslutGetUserDto
            {
                Rows = rowsCount,
                Users = userList,
            };
        }
    }
}