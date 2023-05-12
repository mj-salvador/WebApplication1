﻿using Microsoft.Extensions.Configuration;

public class AppConfig : IAppConfig
{
    public readonly string _testvalue = string.Empty;

    public IConfiguration Configuration { get; }
    public AppConfig(IConfiguration configuration)
    {
        Configuration = configuration;
        _testvalue = Configuration["TestKey"];
    }

    public string GetTestValue()
    {
        return _testvalue;
    }
}
public interface IAppConfig
{
    string GetTestValue();
}