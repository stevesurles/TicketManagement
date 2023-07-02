using TicketManagement.Application.Models.Mail;
using System.Threading.Tasks;

namespace TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
