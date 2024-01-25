using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                Icon = values.Icon,
                Name = values.Name,
                SocialMediaID = values.SocialMediaID,
                Url = values.Url
            };
        }
    }
}
