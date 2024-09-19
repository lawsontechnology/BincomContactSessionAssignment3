namespace BincomContactSessionAssignment3;
public interface IGalleryService 
{
    Task<BaseResponse> AddImage(GalleryRequestModel request);
    Task<ICollection<BaseResponse>> GetAll();
}
