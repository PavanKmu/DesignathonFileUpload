using Designathon.Models;
using Microsoft.EntityFrameworkCore;


namespace Designathon.Data
{
    public class FileUploadDbContext : DbContext
    {
        public FileUploadDbContext(DbContextOptions<FileUploadDbContext> options) : base(options) { }

        public DbSet<FileUploadModel> CandidateDetails { get; set; }
    }
}
    
