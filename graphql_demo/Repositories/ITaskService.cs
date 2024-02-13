using graphql_demo.Entities;

namespace graphql_demo.Repositories
{
    public interface ITaskService
    {
        public Task<List<TaskDetails>> TaskListAsync();

        public Task<TaskDetails> GetTaskDetailByIdAsync(long taskId);
    }
}
