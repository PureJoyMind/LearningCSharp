namespace DbMigration
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}