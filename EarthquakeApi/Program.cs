using System;
using System.IO;
using EarthquakeApi;
using EarthquakeApi.Configuration;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.Configure<EarthquakeDbSettings>(
            builder.Configuration.GetSection("BookStoreDatabase"));
    }
}