using DAO.Models;
using Entities;
using Entities.Models;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ResidenteData
    {
        public List<ResidenteEntity> getAll()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var residentes = context.Residentes.ToList();
                    List<ResidenteEntity> residentesEntity = new List<ResidenteEntity>();
                    foreach (var residente in residentes)
                    {
                        residentesEntity.Add(ResidenteMapper.Map(residente));
                    }
                    return residentesEntity;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ResidenteEntity getById(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var residente = context.Residentes.FirstOrDefault(t => t.ResidenteId == id);
                    if (residente != null)
                    {
                        return ResidenteMapper.Map(residente);
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
