var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();

var app = builder.Build();

// ✅ Make sure this line is here:
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.Run();
