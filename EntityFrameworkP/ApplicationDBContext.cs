using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkP
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) 
        {

        }    
    }
}
