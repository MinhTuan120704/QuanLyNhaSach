﻿using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IConstraintsRepo
    {
        bool UpdateConstraint(Constraints constraint);
        int GetConstraintID(string name);
        string GetConstraintValue(string name);
    }
}
