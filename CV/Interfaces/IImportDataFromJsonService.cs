using CV.Models;

namespace CV.Interfaces
{
    public interface IImportDataFromJsonService
    {
        Task<Profil?> GetCVAsync();
    }
}
