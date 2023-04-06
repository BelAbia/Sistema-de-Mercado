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