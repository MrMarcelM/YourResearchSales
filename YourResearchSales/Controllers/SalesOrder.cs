using YourResearchSales.Models;

namespace YourResearchSales.Controllers
{
    public class SalesOrder
    {
        private readonly ApplicationDbContext _context;

        public SalesOrder(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public void CreateNewOrder ()
        {
            
            Item OrderItem = new Item();
        }
    }
}
