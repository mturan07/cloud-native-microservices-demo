var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Health endpoint (AWS ECS için kritik)
app.MapGet("/health", () => "Order Service OK");

// Example endpoint (opsiyonel)
app.MapGet("/orders", () => new[] { "order-1", "order-2" });

app.Run();
