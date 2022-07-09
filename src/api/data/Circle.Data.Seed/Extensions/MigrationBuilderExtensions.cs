using Circle.Common.Enums;
using Circle.Data.Seed;

namespace Microsoft.EntityFrameworkCore.Migrations;

public static class MigrationBuilderExtensions
{
    public static void MigrateUsers(this MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData("Users",
                                   new string[]
                                   {
                                       "Id","UserName","EMail","Password","PasswordHash","VerificationId","Type","Gender","Address","CountryId","CityId","Phone","IsActive","IsDeleted","CreatedAt","CreatedBy","ModifiedAt","ModifiedBy"
                                   },
                                   new object[,]
                                   {//123.
                                       {ConstantIds.User.AdminId,"admin","admin@circle.com","fc7e5247559cf63a101a236fdb026282","AdminHashValue","123123.",0,2,"Türkiye/Istanbul",null,null,"05325320000",true,false,DateTime.Now,null,DateTime.Now,null, }
                                   },
                                   schema: "Profile");
    }
    public static void MigrateLookups(this MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData("LookupTypes",
                                    new string[]
                                    {
                                        "Id","Name","IsActive","IsDeleted","CreatedAt","CreatedBy","ModifiedAt","ModifiedBy"
                                    },
                                    new object[,]
                                    {
                                        {ConstantIds.LookupType.CountryId,"Ülke",true,false,DateTime.Now,ConstantIds.User.AdminId,DateTime.Now,ConstantIds.User.AdminId},
                                        {ConstantIds.LookupType.CityId,"Şehir",true,false,DateTime.Now,ConstantIds.User.AdminId,DateTime.Now,ConstantIds.User.AdminId}
                                    },
                                    schema: "Main");

        migrationBuilder.InsertData("Lookups",
                                    new string[]
                                    {
                                        "Id","Name","TypeId","ParentId","IsActive","IsDeleted","CreatedAt","CreatedBy","ModifiedAt","ModifiedBy"
                                    },
                                    new object[,]
                                    {
                                        {ConstantIds.Lookup.TurkiyeId,"Türkiye",ConstantIds.LookupType.CountryId,null,true,false,DateTime.Now,null,DateTime.Now,null },
                                        {ConstantIds.Lookup.IstanbulId,"Istanbul",ConstantIds.LookupType.CityId,ConstantIds.Lookup.TurkiyeId,true,false,DateTime.Now,null,DateTime.Now,null }
                                    },
                                    schema: "Main");
    }
}