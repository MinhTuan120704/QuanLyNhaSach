﻿using DAL.Context;
using DAL.IRepo;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ConstraintsRepo : IConstraintsRepo
    {
        private DatabaseContext _context;
        
        public ConstraintsRepo()
        {
            _context = new DatabaseContext();
        }

        public bool UpdateConstraint(Constraints constraint)
        {
            _context.Update(constraint);
            _context.SaveChanges();
            return true;
        }

        public string GetConstraintValue(string name)
        {
            return _context.Constraints.Where(p => p.ConstraintName.ToLower() == name.ToLower()).Select(p => p.ConstraintValue).FirstOrDefault();

        }

        public int GetConstraintID(string name)
        {
            return _context.Constraints.Where(p => p.ConstraintName.ToLower() == name.ToLower()).Select(p => p.ConstraintID).FirstOrDefault();

        }


    }
}
