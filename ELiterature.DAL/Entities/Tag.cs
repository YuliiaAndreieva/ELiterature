using ELiterature.DAL.Entities.Enums;

namespace ELiterature.DAL.Entities;

public class Tag
{
    public long Id { get; set; } 
    
    public string Title { get; set; } 
    
    public TagType Type { get; set; }
}