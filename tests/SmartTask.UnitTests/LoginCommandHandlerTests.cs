using Xunit;
using Moq;
using SmartTask.Application.Features.Auth.Commands;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

public class LoginCommandHandlerTests
{
    [Fact]
    public async Task Login_Should_Return_Token()
    {
        // Arrange
        var userRepoMock = new Mock<IUserRepository>();
        var jwtMock = new Mock<IJwtService>();

        var fakeUser = new User
        {
            Id = Guid.NewGuid(),
            Email = "test@test.com",
            PasswordHash = "123456",
            Role = "User"
        };

        userRepoMock
            .Setup(x => x.GetByEmailAsync(It.IsAny<string>()))
            .ReturnsAsync(fakeUser);

        jwtMock
            .Setup(x => x.GenerateToken(It.IsAny<User>()))
            .Returns("fake-token");

        var handler = new LoginCommandHandler(userRepoMock.Object, jwtMock.Object);

        var command = new LoginCommand
        {
            Email = "test@test.com",
            Password = "123456"
        };

        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.Equal("fake-token", result);
    }
}