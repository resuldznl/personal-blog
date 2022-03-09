using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalBlog.BLL.Abstract;
using PersonalBlog.UI.EmailControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalBlog.UI.BackgroundServices
{
    public class ContactMailService : BackgroundService
    {
        Timer timer;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public ContactMailService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            timer = new Timer(CallMethod, null, TimeSpan.Zero, TimeSpan.FromMinutes(5));
            return Task.CompletedTask;
        }
        public void CallMethod(object state)
        {
            var result = SendContactMail();
        }
        public async Task SendContactMail()
        {
            //A service that sends e-mails in the background so that newly sent contact e-mails do not immediately tire the system.
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var email = scope.ServiceProvider.GetRequiredService<IEmail>();
                var contactService = scope.ServiceProvider.GetRequiredService<IContactService>();
                if (await contactService.IsThereNewContact())
                    await email.SendMail();
            }
        }
    }
}
