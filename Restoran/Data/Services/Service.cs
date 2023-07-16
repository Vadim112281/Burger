using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Restoran.Data.Context;
using Restoran.Models;

namespace Restoran.Data.Services;

public class Service: IService
{
    private readonly AppDbContext _context;

    public Service(AppDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Order>> GetALl()
    {
        return await _context.Orders.ToListAsync();
    }

    public  async Task<bool> Add(Order order)
    {
        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
        
        return true;
    }

    public async Task<bool> Delete(Order order)
    {
        _context.Orders.Remove(order);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<Order> GetById(int id)
    {
       return await _context.Orders.FirstOrDefaultAsync(a => a.Id == id);

    }
}