class Task
{
    public enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted};
    public static void Main()
    {
        TestCaseStatus test1Status = TestCaseStatus.Pass;
        Console.WriteLine(test1Status);
    }
}