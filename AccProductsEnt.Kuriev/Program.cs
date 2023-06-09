using AccProductsEnt.Kuriev;
using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;
using AccProductsEnt.Kuriev.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IRawService, RawService>();

builder.Services.AddScoped<IStaffService, StaffService>();

builder.Services.AddScoped<IAccountCardService, AccountCardService>();

builder.Services.AddScoped<IAccountingService, AccountingService>();

builder.Services.AddScoped<IStorageService, StorageService>();

builder.Services.AddScoped<IProviderService, ProviderService>();

builder.Services.AddScoped<ITechnicalProcessesService, TechnicalProcessesService>();

builder.Services.AddScoped<IWorkshopService, WorkshopService>();

builder.Services.AddScoped<IImplementationsService, ImplementationsService>();

builder.Services.AddScoped<IPostServive, PostService>();

builder.Services.AddScoped<IClientService, ClientSevice>();

builder.Services.AddScoped<IPriceListService, PriceListService>();

builder.Services.AddScoped<IOrderService, OrderService>();

var configuration = builder.Configuration;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("BloggingDatabase")));


builder.Services.AddDefaultIdentity<User>()
               .AddRoles<IdentityRole<int>>()
               .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<UserManager<User>>();
builder.Services.AddScoped<RoleManager<IdentityRole<int>>>();


var app = builder.Build();



using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();

SeedData.EnsureSeedData(scope.ServiceProvider);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
