using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace graphql_demo.Entities
{
    [Table("task_details")]
    public class TaskDetails
    {
        [Key]
        public long TaskID { get; set; }
        public string TaskName { get; set; }
        public long? TaskDisplayID { get; set; }
        public DateTime? TaskDueDate { get; set; }
        public DateTime? TaskStartDate { get; set; }
        public long? AssignedTo { get; set; }

        [Column("TaskCreatedDate")]
        public DateTime? CreatedOn { get; set; }
        public long? TaskProjectID { get; set; }
        public int? TaskPriorityID { get; set; }
        public byte? TaskDifficultyID { get; set; }
        public long? SprintID { get; set; }
        public long? CompetencyID { get; set; }
        public long? TotalBillableHours { get; set; }
        public long? TotalNonBillableHours { get; set; }
    }
}
