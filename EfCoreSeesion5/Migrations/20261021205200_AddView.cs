using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreSeesion5.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(""""

                Create Or Alter View dbo.vw_Top10PostsByScore2
                As
                Select Top(10)
                p.Id as PostId,
                P.Title as PostTitle,
                p.Score as PostScore

                From Posts p

                Inner Join Users U
                on p.OwnerUserId = U.Id

                Order By p.Score DEsc;
                """");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP View IF EXISTS  dbo.vw_Top10PostsByScore2");
        }
    }
}
