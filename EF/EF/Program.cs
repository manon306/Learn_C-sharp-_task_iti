using EF_Core.DAL.sp;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add database
            EF.DAL.DataBase.EFCoreDBContext db = new();
            db.Users.Add(new EF_Core.DAL.Entities.User() { Name = "Menna", Type = EF_Core.DAL.Enum.type.Admin });//كجة كل ما نيجي نرن هيدخلها تاني
            db.SaveChanges();
            //update database
            var result = db.Users.Where(u => u.Id == 3).FirstOrDefault();
            if (result != null)
            {
                result.Name = "Ali";
                db.SaveChanges();
            }

            Console.WriteLine("Hello, World!");
            //Stored Procedure
            //1- اعمله في ال database عادي
            //2-make class SP بنفس الاسم الس في الداتابيز
            //و احط فيه كل ال prop الي في الداتابيز بتاعته

            var result2 = db.Database.SqlQuery<GetAllUset>($"EXEC sp_GetAllUset");
        }
    }
}
