using Ecommerce.Application.Models.ImageManagement;

namespace Ecommerce.Application.Contracts.Infraestructure;

public interface IManageImageService
{
    Task<ImageResponse> UploadImage(ImageData imageStream);
   
}