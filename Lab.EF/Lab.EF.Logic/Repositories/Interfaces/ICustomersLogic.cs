﻿using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Repositories.Interfaces
{
    public interface ICustomersLogic
    {
        Customers GetByIdString(string id);
    }
}
