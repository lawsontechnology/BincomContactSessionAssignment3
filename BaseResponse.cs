namespace BincomContactSessionAssignment3;

public record BaseResponse
{
   public bool Success { get; set; }
   public string? Message { get; set; }
   public GalleryDto? Data { get; set; }
}
