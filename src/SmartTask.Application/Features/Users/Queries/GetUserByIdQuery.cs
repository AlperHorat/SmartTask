using MediatR;
using SmartTask.Application.Features.Users.DTOs;
using System;

namespace SmartTask.Application.Features.Users.Queries
{
    public class GetUserByIdQuery : IRequest<UserDto>
    {
        public Guid Id { get; set; }

        public GetUserByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}