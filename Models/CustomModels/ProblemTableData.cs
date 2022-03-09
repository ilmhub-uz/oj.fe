namespace oj.fe.Models.CustomModels;

public class ProblemTableData
{
    public bool IsSolved { get; set; } = false;

    public string Id { get; set; }
    
    public string Title { get; set; }
    
    public string Level { get; set; }
    
    public int Total { get; set; }
    
    public string ACRate { get; set; }
}