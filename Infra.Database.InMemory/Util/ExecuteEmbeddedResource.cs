namespace Infra.Database.InMemory.Util
{
    public class ExecuteEmbeddedResource
    {
        public static string GetSqlScript(string filepath)
        {
            return File.ReadAllText(filepath) ?? "";
        }
    }
}
