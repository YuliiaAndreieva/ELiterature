using ELiterature.DAL.Entities.Enums;

namespace ELiterature.DAL.Entities;

public class AuthorPhoto
{
    public long Id { get; set; }
    
    public AuthorPhotoType Type { get; set; }
    
    public string PhotoUrl { get; set; } = string.Empty;
    
    public string? Quote { get; set; }
    
    public int AuthorId { get; set; }
    
    public Author Author { get; set; } = null!;
}