﻿using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Implements
{
    public class PermissionService : BaseService<Permission>, IPermissionService
    {
        public PermissionService(IRepository<Permission> repository) : base(repository)
        {
        }
    }
}
