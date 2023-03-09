using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCategoriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Rusia" });
                _context.Countries.Add(new Country { Name = "Canadá" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Televisores" });
                _context.Categories.Add(new Category { Name = "Celulares" });
                _context.Categories.Add(new Category { Name = "Computadores" });
                _context.Categories.Add(new Category { Name = "Moda" });
                _context.Categories.Add(new Category { Name = "Jugueteria" });
                _context.Categories.Add(new Category { Name = "Deporte" });
                _context.Categories.Add(new Category { Name = "Hogar" });
                _context.Categories.Add(new Category { Name = "Cuidado personal" });
                _context.Categories.Add(new Category { Name = "Cocina" });
                _context.Categories.Add(new Category { Name = "Libros" });
                _context.Categories.Add(new Category { Name = "Impresoras" });
                _context.Categories.Add(new Category { Name = "Calculadora" });
                _context.Categories.Add(new Category { Name = "Camisas" });
                _context.Categories.Add(new Category { Name = "Tenis" });
                _context.Categories.Add(new Category { Name = "Camisetas" });
                _context.Categories.Add(new Category { Name = "Motos" });
                _context.Categories.Add(new Category { Name = "Camiones" });
                _context.Categories.Add(new Category { Name = "Bolsos" });
                _context.Categories.Add(new Category { Name = "Jeans" });
                _context.Categories.Add(new Category { Name = "Tacones" });
                _context.Categories.Add(new Category { Name = "Medias" });
                _context.Categories.Add(new Category { Name = "Viajes" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
