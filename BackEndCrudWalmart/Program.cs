using BackEndCrudWalmart.Models;
using Microsoft.EntityFrameworkCore;

using BackEndCrudWalmart.Services.Producto;

using BackEndCrudWalmart.Services.Implementacion;


using AutoMapper;
using BackEndCrudWalmart.DTOs;
using BackEndCrudWalmart.Utilidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<AbastoContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<ICat_ProductService, Cat_Product_Service>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


#region Peticiones API REST
app.MapGet("/CatProduct/lista", async(
    ICat_ProductService _ProductService,
    IMapper  _mapper
    ) =>
{
    var listaCatProducto = await _ProductService.GetList();
    var listaCatProductoDTO = _mapper.Map<List<Cat_Product_DTO>>(listaCatProducto);

    if (listaCatProductoDTO.Count > 0)
        return Results.Ok(listaCatProductoDTO);
    else
        return Results.NotFound();


});

app.MapPost("/CatProduct/guardar", async (
    Cat_Product_DTO modelo,
    ICat_ProductService _ProductService,
    IMapper _mapper
    ) =>
{
    var _producto = _mapper.Map<AtCatProduct>(modelo);
    var _productoCreado = await _ProductService.Add(_producto);


    if (_productoCreado.IdProductTypeGdm != 0)
        return Results.Ok(_mapper.Map<Cat_Product_DTO>(_productoCreado));
    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError);


});

app.MapPut("/CatProduct/actualizar/{UniqueNumber}", async (
    int idProducto,
    Cat_Product_DTO modelo,
    ICat_ProductService _ProductService,
    IMapper _mapper
    ) =>
{
    var _encontrado = await _ProductService.Get(idProducto);

    if (_encontrado is null) return Results.NotFound();

    var _producto = _mapper.Map<AtCatProduct>(modelo);

    _encontrado.UniqueNumber = _producto.UniqueNumber;
    _encontrado.Environment = _producto.Environment;
    _encontrado.Level = _producto.Level;
    _encontrado.ColumnUpdated = _producto.ColumnUpdated;

    var respuesta = await _ProductService.Update(_encontrado);

    if (respuesta)
        return Results.Ok(_mapper.Map<Cat_Product_DTO>(_encontrado));
    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError); 
});

app.MapDelete("/CatProduct/eliminar/{UniqueNumber}", async (
    int idProducto,
    ICat_ProductService _ProductService
    ) =>
{
    var _encontrado = await _ProductService.Get(idProducto);

    if (_encontrado is null) return Results.NotFound();

    var respuesta = await _ProductService.Delete(_encontrado);

    if (respuesta)
        return Results.Ok();
    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError);


});
#endregion

app.Run();
