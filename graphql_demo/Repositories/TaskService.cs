using graphql_demo.Data;
using graphql_demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace graphql_demo.Repositories
{
    public class TaskService : ITaskService
    {
        private readonly DbContextClass dbContextClass;

        public TaskService(DbContextClass dbContextClass)
        {
            this.dbContextClass = dbContextClass;
        }

        public async Task<List<TaskDetails>> TaskListAsync()
        {
            return await dbContextClass.Tasks.ToListAsync();
        }

        public async Task<TaskDetails> GetTaskDetailByIdAsync(long taskId)
        {
            return await dbContextClass.Tasks.Where(ele => ele.TaskID == taskId).FirstOrDefaultAsync();
        }
    }
}
