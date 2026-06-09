using Xunit;
using Moq;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

public class TaskCreateTests
{
    [Fact]
    public async Task Should_Create_Task_Through_Repository()
    {
        // Arrange
        var taskRepoMock = new Mock<ITaskRepository>();

        taskRepoMock
            .Setup(x => x.AddAsync(It.IsAny<TaskItem>()))
            .Returns(Task.CompletedTask);

        var task = new TaskItem
        {
            Title = "Test Task",
            Description = "Test Desc",
            ProjectId = Guid.NewGuid()
        };

        // Act
        await taskRepoMock.Object.AddAsync(task);

        // Assert
        taskRepoMock.Verify(x => x.AddAsync(It.IsAny<TaskItem>()), Times.Once);
    }
}