namespace ELiterature.DAL.Entities;

public class Author
{
    public long Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string MiddleName { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public DateTime? DateOfDeath { get; set; } 
    
    public string Biography { get; set; } = string.Empty;
    
    public IEnumerable<LiteratureDirection> LiteratureDirections { get; set; }
    
    public List<LiteraryWork> LiteraryWorks { get; set; }
}