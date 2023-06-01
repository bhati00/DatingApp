namespace API.Extensions;

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateOnly Dob)
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);
        var age = today.Year - Dob.Year;
        if(Dob > today.AddYears(-age)) age--;
        return age;
    }
}