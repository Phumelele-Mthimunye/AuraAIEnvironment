namespace Aura.Domain.Common;

public abstract class AuditableEntity : BaseEntity
{
    public DateTime CreatedDate { get; protected set; }

    public DateTime? ModifiedDate { get; protected set; }


    protected AuditableEntity()
    {
        CreatedDate = DateTime.UtcNow;
    }


    public void UpdateModifiedDate()
    {
        ModifiedDate = DateTime.UtcNow;
    }
}