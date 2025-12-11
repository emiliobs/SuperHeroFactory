using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Domain.UnitOfWorks;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}