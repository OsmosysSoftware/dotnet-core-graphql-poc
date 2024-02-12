using graphql_demo.Data;
using graphql_demo.GraphQL.Mutations;
using graphql_demo.GraphQL.QueryTypes;
using graphql_demo.GraphQL.Types;
using graphql_demo.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Register Service
builder.Services.AddScoped<ITaskService, TaskService>();

// Database
builder.Services.AddDbContext<DbContextClass>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("DBConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

//GraphQL Config
builder.Services.AddGraphQLServer()
    .AddQueryType<TaskQueryTypes>();

var app = builder.Build();

//GraphQL
app.MapGraphQL();
app.UseHttpsRedirection();
app.Run();
