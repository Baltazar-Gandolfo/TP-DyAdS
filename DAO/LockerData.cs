using DAO.Models;
using Entities;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LockerData
    {
        public List<LockerEntity> getAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var lockers = context.Lockers
                        .Include(locks => locks.idRepartidorNavigation)
                        .Include(locks => locks.idResidenteNavigation)
                        .Select(locks => LockerMapper.Map(locks))
                        .ToList();
                    return lockers;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public LockerEntity getById(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var locker = context.Lockers
                        .Include(locks => locks.idRepartidorNavigation)
                        .Include(locks => locks.idResidenteNavigation)
                        .Where(locks => locks.LockerId == id)
                        .Select(locks => LockerMapper.Map(locks))
                        .FirstOrDefault();
                    return locker;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
