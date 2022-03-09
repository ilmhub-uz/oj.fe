namespace oj.fe.Models.CustomModels;

public class SubmissionResultTableData
{
    public string Id { get; set; }
    
    public string Status { get; set; }
    
    public int  MemoryInBytes { get; set; }
    
    public int TimeInMilliseconds { get; set; }
    
    public double Score { get; set; }
}