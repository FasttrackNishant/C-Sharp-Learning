namespace Simplify_CSharp_Code;

public record EmployeeRecord(int Id, string Name);


public class EmployeeRecordModel
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
}
