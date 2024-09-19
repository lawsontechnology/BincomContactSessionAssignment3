namespace BincomContactSessionAssignment3;
public interface IGalleryRepository
{
    Task<Gallery> AddAsync (Gallery gallery);
    Task<ICollection<Gallery>> GetAll();
    Task<int> SaveChanges();
}
