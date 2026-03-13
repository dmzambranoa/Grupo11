using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interface
{
    public interface IAlmacenRepository : IRepositoryBase<Almacen>
    {
        Task<IEnumerable<Almacen>> GetAllAsync();
        Task<Almacen> GetByIdAsync(int id);
        Task AddAsync(Almacen almacen);
        Task UpdateAsync(Almacen almacen);
        Task DeleteAsync(int id);
    }
}
