using dotenv.net;

namespace LKonfig.Providers;

public class DotEnvConfigProvider : IConfigProvider
{
    public void Load()
    {
        DotEnv.Load();
    }
}