using AutomapperVsMapperly.Dto;

namespace AutomapperVsMapperly.Mappers;

public class MapWithCustomMapper
{
    public static ClassTwo MapToClassTwo(ClassOne one)
    {
        var target = new ClassTwo()
        {
            Id = one.Id,
            FirstName = one.FirstName,
            LastName = one.LastName,
            Email = one.Email,
            Address = one.Address,
            City = one.City,
            State = one.State,
            Country = one.Country,
            ZipCode = one.ZipCode,
            PhoneNumber = one.PhoneNumber,
            Username = one.Username,
            Age = one.Age,
            Salary = one.Salary,
            HoursWorked = one.HoursWorked,
            Department = one.Department,
            CreditScore = one.CreditScore,
            DateOfBirth = one.DateOfBirth,
            HireDate = one.HireDate,
            LastPromotionDate = one.LastPromotionDate,
            LastLoginDate = one.LastLoginDate,
            AccountExpirationDate = one.AccountExpirationDate
        };

        return target;
    }
}