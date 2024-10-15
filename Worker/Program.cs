using Worker;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<WorkerQuotation>();

var host = builder.Build();
host.Run();
