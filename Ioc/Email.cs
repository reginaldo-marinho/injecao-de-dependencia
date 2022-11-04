using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ioc
{
    public class Email : BackgroundService
    {
        IMessageWriter _messageWriter;
        public Email(IMessageWriter messageWriter)
        {
            _messageWriter = messageWriter;
        }

        public void EnviarEmail()
        {
            _messageWriter.Write("Ola Reginaldo");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            EnviarEmail();
        }
    }
}
