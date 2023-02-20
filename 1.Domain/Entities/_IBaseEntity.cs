namespace _1.Domain;

public interface IBaseEntity
{
    Guid Id { get; set; }
    DateTime CreatedUTC { get; set; }
    DateTime UpdatedUTC { get; set; }
    bool IsActive { get; set; } 
}