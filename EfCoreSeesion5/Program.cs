using EfCoreSeesion5.Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
var rep = 100000;
var dbContext = new Stackoverflow2010Context();
// Proc
//var topUsers = await dbContext
//   //.Users
//   // .FromSqlRaw("SELECT * From Users Where Reputation>{0}", rep) x
//   // .FromSqlInterpolated($"SELECT * From Users Where Reputation>{rep}") .Net 7
//   //.FromSql($"SELECT * From Users Where Reputation>{rep}")
//   .Users
//   .FromSql($"EXEC dbo.GetTop5Users")
//    .ToListAsync();
//foreach (var item in topUsers)
//{
//    Console.WriteLine(item.Id + "  ");
//    Console.WriteLine(item.DisplayName);
//}


//view
dbContext.Database.SetCommandTimeout(60);

var result = await dbContext.TopPostScores
    .ToListAsync();

foreach (var item in result)
{
    Console.WriteLine(item);
}

//public class UserResponse
//{
//    public int Id { get; set; }
//    public string DisplayName { get; set; }
//}