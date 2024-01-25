using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class RemoveSocialMediaCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveSocialMediaCommand(int id)
        {
            Id = id;
        }
    }
}
