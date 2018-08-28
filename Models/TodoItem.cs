using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        //props
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        [DefaultValue(false)]
        public bool IsComplete { get; set; }
        public int UserId { get; set; }
        public List<Task> TaskList { get; set; }

        // methods
        public int GetTotalTaskCount() {
            return TaskList.Count;
        }

        public int GetCompletedTaskCount() {
            return TaskList.Count
                           .Where(t => t.IsComplete == true);
        }

        public int GetCompletionPercentage() {
            return TaskList.Count
                            .Where(t => t.IsComplete == true) / TaskList.Count;
        }
    }
}