using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class RemoveFeatureCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveFeatureCommand(int id)
        {
            Id = id;
        }
    }
}
