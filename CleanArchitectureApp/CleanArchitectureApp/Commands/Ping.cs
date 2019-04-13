using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureApp.Commands
{
    public class Ping : IRequest<Pong>
    {
        public Ping(string text)
        {
            Message = text;
        }

        public string Message { get; private set; }
    }
}