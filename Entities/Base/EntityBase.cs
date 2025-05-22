using System.ComponentModel.DataAnnotations;

namespace BookSpaceApi.Entities.Base;

public abstract class EntityBase
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
}
