using DAO.Models;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RepartidorData
    {
        public List<RepartidorEntity> getAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var repartidores = context.Repartidores.ToList();
                    List<RepartidorEntity> repartidoresEntity = new List<RepartidorEntity>();
                    foreach (var repartidor in repartidores)
                    {
                        repartidoresEntity.Add(RepartidorMapper.Map(repartidor));
                    }
                    return repartidoresEntity;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public RepartidorEntity getById(string id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var repartidor = context.Repartidores.FirstOrDefault(t => Convert.ToString(t.RepartidorId) == id);
                    if (repartidor != null)
                    {
                        return RepartidorMapper.Map(repartidor);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
