namespace Theory_Heritage;

public abstract class Person
{
    public required string Firstname { get; set; } = default!;
    public required string Lastname { get; set; } = default!;

    public required DateTime Birth { get; set; }

    public virtual int CalculAge()
    {
        var today = DateTime.Today;

        var a = (today.Year * 100 + today.Month) * 100 + today.Day;
        var b = (Birth.Year * 100 + Birth.Month) * 100 + Birth.Day;

        return (a - b) / 10000;
    }
}

