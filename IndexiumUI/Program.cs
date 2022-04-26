// var builder = WebApplication.CreateBuilder(args);
//
// // Add services to the container.
//
// builder.Services.AddControllersWithViews();
//
// var app = builder.Build();
//
// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }
//
// app.UseHttpsRedirection();
// app.UseStaticFiles();
// app.UseRouting();
//
//
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller}/{action=Index}/{id?}");
//
// app.MapFallbackToFile("index.html");
//
// app.Run();

using IndexiumUI.DataBase;
using IndexiumUI.Entities;

var dataBaseWorker = new DataBaseWorker();
City city = new City("Орел4", "климат","координаты", 55);
// dataBaseWorker.ReadDataFromDataBase("SELECT name FROM district WHERE city_id = 1");
dataBaseWorker.WriteDataToDataBase(DataBaseAPI.SetCityInDataBase(city));

