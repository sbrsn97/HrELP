﻿using HrELP.Domain.Entities.Concrete;
using HrELP.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrELP.Infrastructure.Repositories
{
    public class AppRoleRepository: BaseRepository<AppRole>, IAppRoleRepository
    {
        public AppRoleRepository(HrElpContext context) : base(context)
        {

        }
    }
}
