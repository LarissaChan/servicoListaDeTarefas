﻿namespace ListaDeTarefasApi;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMemoryCache();
    }
}
