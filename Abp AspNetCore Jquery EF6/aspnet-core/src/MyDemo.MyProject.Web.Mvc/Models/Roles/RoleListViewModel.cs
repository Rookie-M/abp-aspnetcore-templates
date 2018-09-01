﻿using System.Collections.Generic;
using MyDemo.MyProject.Roles.Dto;

namespace MyDemo.MyProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
