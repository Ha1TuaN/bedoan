using System.Xml.Linq;

namespace TD.KCN.WebApi.Domain.House;
public class ImageHouse : AuditableEntity, IAggregateRoot
{
    public string Image { get; set; } = default!;
    public Guid? MotelId { get; set; }
    public virtual Motel? Motel { get; set; }
    public ImageHouse(
       string image,
       Guid? motelId
    )
    {
        Image = image;
        MotelId = motelId;
    }

    public ImageHouse Update(string? image)
    {
        Image = image ?? Image;

        return this;
    }
}
