using System.ComponentModel.DataAnnotations.Schema;
using ELiterature.DAL.Entities.Enums;

namespace ELiterature.DAL.Entities;

public class LiteraryWork
{
    public long Id { get; set; } 
    
    public string Title { get; set; } 
    
    public string Description { get; set; } 
    
    public int Year { get; set; } 
    
    public LiteraryWorkType Type { get; set; } 
    
    public string Text { get; set; }
    
    public IEnumerable<Author> Authors { get; set; } 
    
    public IEnumerable<LiteratureDirection> LiteraryDirections { get; set; }
}