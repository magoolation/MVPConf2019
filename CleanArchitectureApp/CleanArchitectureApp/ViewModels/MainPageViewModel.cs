using CleanArchitectureApp.Commands;
using MediatR;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CleanArchitectureApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private readonly IMediator mediator;
        public MainPageViewModel(INavigationService navigationService, IMediator mediator)
            : base(navigationService)
        {
            Title = "Main Page";
            this.mediator = mediator;

            SendCommand = new DelegateCommand(Send);
        }

        private async void Send()
        {
            var pong = await mediator.Send(new Ping(text));
            Message = pong.Message;

        }

        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        private string message;
        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }

        public ICommand SendCommand { get; }
    }
}