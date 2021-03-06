﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aglaia.Model;

namespace Aglaia.Data
{
    public interface IBuildingRepository
    {
        IEnumerable<Building> Get();

        Building Get(int id);

        List<Building> GetTop();

        List<Building> GetChildren(int parentId);
    }
}
