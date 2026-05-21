using MediatR;
using SmartTask.Application.Features.Users.DTOs;
using System.Collections.Generic;

namespace SmartTask.Application.Features.Users.Queries
{
    public class GetAllUsersQuery : IRequest<List<UserDto>>
    {
    }
}