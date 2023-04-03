namespace Theory_Heritage;

public class Student : Person, IDelete
{
    public double FinalRate { get; set; }
    public DateTime? DeletedAt { get; set; }

    public void Delete()
    {
        DeletedAt = DateTime.Now;
    }
}