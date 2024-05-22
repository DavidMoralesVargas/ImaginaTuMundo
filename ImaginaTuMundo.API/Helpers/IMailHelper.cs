
using ImaginaTuMundo.Shared.Response;

namespace ImaginaTuMundo.API.Helpers
{
    public interface IMailHelper
    {
        Response<string> SendMail(string toName, string toEmail, string subject, string body);
    }
}
