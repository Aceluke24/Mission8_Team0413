namespace Mission8_Team0413.Models;

public interface ITaskRepository //Serves as a template for the template
{
    List<Task> Tasks { get; }
    public void AddTask(Task task);
    public void UpdateTask(Task task);
    public void DeleteTask(int taskId);
}