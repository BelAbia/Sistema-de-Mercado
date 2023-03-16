using Microsoft.AspNetCore.StaticFiles;
using Sistema_de_Mercado;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();


    builder.Services.AddCors();
    builder.Services.AddScoped<IRepositorio, RepositorioLinq2Db>();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseCors(options => options.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
       );
    app.UseAuthentication();
    app.UseDefaultFiles();
    app.UseStaticFiles();
    app.UseStaticFiles(new StaticFileOptions()
    {
        ContentTypeProvider = new FileExtensionContentTypeProvider
        {
            Mappings = { [".properties"] = "application/x-msdownload" }
        }
    });
    app.MapControllers();
    app.Run();
}

















//using Sistema_de_Mercado;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
////builder.Services.AddSwaggerGen();

//builder.Services.AddCors();
//builder.Services.AddScoped<IRepositorio, RepositorioLinq2Db>();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
////if (app.Environment.IsDevelopment())
////{
////    app.UseSwagger();
////    app.UseSwaggerUI();
////}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();