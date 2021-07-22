using System.Threading.Tasks;

namespace BlazorUserRegLog.Services
{
    public interface IHttpService
    {
        Task<T> Get<T>(string url);
        Task Post(string url, object val);
        Task<T> Post<T>(string url, object val);
        Task Put(string url, object val);
        Task<T> Put<T>(string url, object val);
        Task Delete(string url);
        Task<T> Delete<T>(string url);
    }
}