namespace Assignment1.Models;
public class Customer
{
    public string? RequestNumber { get; set; }
    public string? PortNumber { get; set; }
    public string? PortDesc { get; set; }
    public string? RequestType { get; set; }
    public string? DistributorCode { get; set; }
    public int BranchCode { get; set; }
    public string? DelearNetPrice { get; set; }
    public DateTime RequestDateTo { get; set; }
}