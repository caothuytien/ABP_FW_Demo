using System.Collections.Generic;
using NewDemo.Roles.Dto;
using NewDemo.Users.Dto;

namespace NewDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
