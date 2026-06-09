using Xunit;
using Moq;
using SmartTask.Application.Features.Auth.Commands;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

public class RegisterCommandHandlerTests
{
    [Fact]
    public async Task Register_Should_Create_User()
    {
        // Arrange
        var userRepoMock = new Mock<IUserRepository>();

        userRepoMock
            .Setup(x => x.AddAsync(It.IsAny<User>()))
            .Returns(Task.CompletedTask);

        var handler = new RegisterCommandHandler(userRepoMock.Object);

        var command = new RegisterCommand
        {
            UserName = "testuser",
            Email = "test@test.com",
            Password = "123456"
        };

        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        userRepoMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
    }
}