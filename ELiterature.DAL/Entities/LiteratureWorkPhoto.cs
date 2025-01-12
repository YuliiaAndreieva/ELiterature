using ELiterature.DAL.Entities.Enums;

namespace ELiterature.DAL.Entities;

public class LiteratureWorkPhoto
{
    public long Id { get; set; }
    
    public PhotoType Type { get; set; }
    
    public string PhotoUrl { get; set; } = string.Empty;
}