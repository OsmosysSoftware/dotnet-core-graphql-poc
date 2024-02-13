using graphql_demo.Entities;
using graphql_demo.Repositories;

namespace graphql_demo.GraphQL.QueryTypes
{
    public class TaskQueryTypes
    {
        public async Task<List<TaskDetails>> GetTaskListAsync([Service] ITaskService taskService)
        {
            return await taskService.TaskListAsync();
        }

        public async Task<TaskDetails> GetTaskDetailsByIdAsync([Service] ITaskService taskService, long taskId)
        {
            return await taskService.GetTaskDetailByIdAsync(taskId);
        }
    }
}
