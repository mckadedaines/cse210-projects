public class Job
{
    private string _company = "";
    private string _jobTitle = "";
    private int _startYear = 0;
    private int _endYear = 0;

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public int StartYear
    {
        get { return _startYear; }
        set { _startYear = value; }
    }

    public int EndYear
    {
        get { return _endYear; }
        set { _endYear = value; }
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
    }
}