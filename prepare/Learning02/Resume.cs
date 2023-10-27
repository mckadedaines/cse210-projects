// Leeps track of the person's name and a lsit of their jobs
// Should display the name first, followed by displaying each one of the jobs.
public class Resume
{
    private string _name = "";
    private List<Job> _jobs = new List<Job>();

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public List<Job> Jobs
    {
        get { return _jobs; }
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}