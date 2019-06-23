﻿using PTC.Domain.EF.Context;
using PTC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTC.Domain.EF.Commands
{
    public class CalculationCommands : CommandBase
    {
        public CalculationCommands(ApplicationContext applicationContext) 
            : base(applicationContext)
        {

        }

        public TaxCalculation AddCalculation(TaxCalculation calculation)
        {
            _context.Add(calculation);
            _context.SaveChanges();

            return calculation;
        }
        public TaxCalculation UpdateCalculation(TaxCalculation calculation)
        {
            _context.Attach(calculation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.Update(calculation);
            _context.SaveChanges();

            return calculation;
        }
        public bool DeleteCalculation(TaxCalculation calculation)
        {
            _context.Attach(calculation).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();

            return true;
        }
    }
}