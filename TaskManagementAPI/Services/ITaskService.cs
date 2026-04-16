using TaskManagementAPI.DTOs;

namespace TaskManagementAPI.Services
{
    public interface ITaskService
    {
        Task<TaskResponseDto> CreateTaskAsync(CreateTaskDto createTaskDto, int userId);
        Task<List<TaskResponseDto>> GetUserTaskAsync(int userId);

        Task<TaskResponseDto?> GetTaskByIdAsync(int taskId, int userId);
    }
}
