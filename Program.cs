var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var ap = builder.Build();

// Configure the HTTP request pipeline.
if (!ap.Environment.IsDevelopment())
{
    ap.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    ap.UseHsts();
}

ap.UseHttpsRedirection();
ap.UseStaticFiles();

ap.UseRouting();

ap.UseAuthorization();

ap.MapRazorPages();

ap.Run();
