using Microsoft.AspNetCore.WebUtilities;

namespace FileUploadManager.Interfaces
{
    public interface IStreamFileUploadService
    {
        Task<bool> UploadFile(MultipartReader reader, MultipartSection section);
    }
}
