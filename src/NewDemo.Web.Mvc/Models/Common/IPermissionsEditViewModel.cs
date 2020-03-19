using System.Collections.Generic;
using NewDemo.Roles.Dto;

namespace NewDemo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}