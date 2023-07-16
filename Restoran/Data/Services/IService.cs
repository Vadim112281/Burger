using Restoran.Models;

namespace Restoran.Data.Services;

public interface IService
{
     Task<IEnumerable<Order>> GetALl();
     Task<bool> Add(Order order);
     Task<bool> Delete(Order order);
     Task<Order> GetById(int id);
}