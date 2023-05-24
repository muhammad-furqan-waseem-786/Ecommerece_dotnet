using Ecommerece_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerece_dotnet.Data.Services
{
    public class ActorsServices : IActorsService
    {
        private readonly AppDbContext _context;
        
        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id  == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();  
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
