using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Services
{
    public interface IEmailService
    {
        Task SendResetPasswordEmail(string resetEmailLink, string To);

    }
}
