using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreSeesion5.Migrations
{
    /// <inheritdoc />
    public partial class YourMigrationName : Migration
    {
        /// <inheritdoc />
        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.CreateTable(
        //        name: "AccountBalance",
        //        columns: table => new
        //        {
        //            AccountId = table.Column<int>(type: "int", nullable: false),
        //            AccountName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
        //            Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__AccountB__349DA5A6440E7185", x => x.AccountId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditLog",
        //        columns: table => new
        //        {
        //            AuditId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            TableName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
        //            OperationType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            ChangeDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
        //            OldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__AuditLog__A17F2398BCEBEDAD", x => x.AuditId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditTrail",
        //        columns: table => new
        //        {
        //            AuditId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            TableName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
        //            Operation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
        //            RecordId = table.Column<int>(type: "int", nullable: true),
        //            OldValue = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
        //            NewValue = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
        //            AuditDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
        //            UserName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true, defaultValueSql: "(suser_sname())")
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__AuditTra__A17F239884C2205D", x => x.AuditId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BankAccounts",
        //        columns: table => new
        //        {
        //            AccountId = table.Column<int>(type: "int", nullable: false),
        //            AccountHolder = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
        //            Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            LastModified = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__BankAcco__349DA5A63AA37696", x => x.AccountId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ChangeLog",
        //        columns: table => new
        //        {
        //            ChangeLogId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ActionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
        //            TableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
        //            OldValue = table.Column<int>(type: "int", nullable: true),
        //            NewValue = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__ChangeLo__6AD2E8C7B1E9540D", x => x.ChangeLogId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CommentsAuditLog",
        //        columns: table => new
        //        {
        //            AuditId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CommentId = table.Column<int>(type: "int", nullable: true),
        //            OperationType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
        //            OldText = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            NewText = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OldScore = table.Column<int>(type: "int", nullable: true),
        //            NewScore = table.Column<int>(type: "int", nullable: true),
        //            ChangedBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
        //            ChangeDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__Comments__A17F239893D936DA", x => x.AuditId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DDLAuditLog",
        //        columns: table => new
        //        {
        //            EventId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            EventType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
        //            EventDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
        //            LoginName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
        //            TSQLCommand = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DatabaseName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__DDLAudit__7944C81082483A4D", x => x.EventId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DeletedPosts",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            DeletedPostId = table.Column<int>(type: "int", nullable: true),
        //            OwnerUserId = table.Column<int>(type: "int", nullable: true),
        //            Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
        //            Score = table.Column<int>(type: "int", nullable: true),
        //            CreationDate = table.Column<DateOnly>(type: "date", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__DeletedP__3214EC077E0BD370", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "LinkTypes",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_LinkTypes__Id", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "PostTypes",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PostTypes__Id", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionLog",
        //        columns: table => new
        //        {
        //            LogId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AccountId = table.Column<int>(type: "int", nullable: true),
        //            TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
        //            Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            TransactionDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
        //            Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__Transact__5E54864885F7C398", x => x.LogId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransferHistory",
        //        columns: table => new
        //        {
        //            TransferId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            FromAccountId = table.Column<int>(type: "int", nullable: true),
        //            ToAccountId = table.Column<int>(type: "int", nullable: true),
        //            Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            TransferDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
        //            Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
        //            ErrorMessage = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__Transfer__95490091CDB2B34A", x => x.TransferId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Users",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Age = table.Column<int>(type: "int", nullable: true),
        //            CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
        //            DisplayName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
        //            DownVotes = table.Column<int>(type: "int", nullable: false),
        //            EmailHash = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
        //            LastAccessDate = table.Column<DateTime>(type: "datetime", nullable: false),
        //            Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
        //            Reputation = table.Column<int>(type: "int", nullable: false),
        //            UpVotes = table.Column<int>(type: "int", nullable: false),
        //            Views = table.Column<int>(type: "int", nullable: false),
        //            WebsiteUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
        //            AccountId = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Users_Id", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VoteTypes",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VoteType__Id", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Posts",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AcceptedAnswerId = table.Column<int>(type: "int", nullable: true),
        //            AnswerCount = table.Column<int>(type: "int", nullable: true),
        //            Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            ClosedDate = table.Column<DateTime>(type: "datetime", nullable: true),
        //            CommentCount = table.Column<int>(type: "int", nullable: true),
        //            CommunityOwnedDate = table.Column<DateTime>(type: "datetime", nullable: true),
        //            CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
        //            FavoriteCount = table.Column<int>(type: "int", nullable: true),
        //            LastActivityDate = table.Column<DateTime>(type: "datetime", nullable: false),
        //            LastEditDate = table.Column<DateTime>(type: "datetime", nullable: true),
        //            LastEditorDisplayName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
        //            LastEditorUserId = table.Column<int>(type: "int", nullable: true),
        //            OwnerUserId = table.Column<int>(type: "int", nullable: true),
        //            ParentId = table.Column<int>(type: "int", nullable: true),
        //            PostTypeId = table.Column<int>(type: "int", nullable: false),
        //            Score = table.Column<int>(type: "int", nullable: false),
        //            Tags = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
        //            Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
        //            ViewCount = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Posts__Id", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Posts_PostTypes",
        //                column: x => x.PostTypeId,
        //                principalTable: "PostTypes",
        //                principalColumn: "Id");
        //            table.ForeignKey(
        //                name: "FK_Posts_Posts",
        //                column: x => x.ParentId,
        //                principalTable: "Posts",
        //                principalColumn: "Id");
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Badges",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            Date = table.Column<DateTime>(type: "datetime", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Badges__Id", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Badges_Users",
        //                column: x => x.UserId,
        //                principalTable: "Users",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.SetNull);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Comments",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
        //            PostId = table.Column<int>(type: "int", nullable: false),
        //            Score = table.Column<int>(type: "int", nullable: true),
        //            Text = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Comments__Id", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Comments_Posts",
        //                column: x => x.PostId,
        //                principalTable: "Posts",
        //                principalColumn: "Id");
        //            table.ForeignKey(
        //                name: "FK_Comments_Users",
        //                column: x => x.UserId,
        //                principalTable: "Users",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.SetNull);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "PostLinks",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
        //            PostId = table.Column<int>(type: "int", nullable: false),
        //            RelatedPostId = table.Column<int>(type: "int", nullable: false),
        //            LinkTypeId = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PostLinks__Id", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_PostLinks_LinkTypes",
        //                column: x => x.LinkTypeId,
        //                principalTable: "LinkTypes",
        //                principalColumn: "Id");
        //            table.ForeignKey(
        //                name: "FK_PostLinks_Posts",
        //                column: x => x.PostId,
        //                principalTable: "Posts",
        //                principalColumn: "Id");
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Votes",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            PostId = table.Column<int>(type: "int", nullable: false),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            BountyAmount = table.Column<int>(type: "int", nullable: true),
        //            VoteTypeId = table.Column<int>(type: "int", nullable: false),
        //            CreationDate = table.Column<DateTime>(type: "datetime", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Votes__Id", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Votes_Posts",
        //                column: x => x.PostId,
        //                principalTable: "Posts",
        //                principalColumn: "Id");
        //            table.ForeignKey(
        //                name: "FK_Votes_Users",
        //                column: x => x.UserId,
        //                principalTable: "Users",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.SetNull);
        //            table.ForeignKey(
        //                name: "FK_Votes_VoteTypes",
        //                column: x => x.VoteTypeId,
        //                principalTable: "VoteTypes",
        //                principalColumn: "Id");
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Badges_UserId",
        //        table: "Badges",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Comments_PostId",
        //        table: "Comments",
        //        column: "PostId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Comments_UserId",
        //        table: "Comments",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PostLinks_LinkTypeId",
        //        table: "PostLinks",
        //        column: "LinkTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PostLinks_PostId",
        //        table: "PostLinks",
        //        column: "PostId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Post",
        //        table: "Posts",
        //        columns: new[] { "OwnerUserId", "Score", "CreationDate" },
        //        descending: new[] { false, true, false },
        //        filter: "([OwnerUserId]=(22656) AND [Score]>(100) AND [Title] IS NOT NULL)");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Posts_ParentId",
        //        table: "Posts",
        //        column: "ParentId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Posts_PostTypeId",
        //        table: "Posts",
        //        column: "PostTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Users_DisplayName",
        //        table: "Users",
        //        column: "DisplayName",
        //        unique: true,
        //        descending: new bool[0]);

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Users_Reputation",
        //        table: "Users",
        //        column: "Reputation",
        //        descending: new bool[0]);

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Votes_PostId",
        //        table: "Votes",
        //        column: "PostId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Votes_UserId",
        //        table: "Votes",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Votes_VoteTypeId",
        //        table: "Votes",
        //        column: "VoteTypeId");
        //}

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                    CREATE OR ALTER PROC dbo.GetTop5Users
                AS

                Begin
                    SELECT TOP(5) * 
                    FROM Users
                    ORDER BY Reputation DESC

                End
                """);
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROC IF EXISTS dbo.GetTop5Users");
        }
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "AccountBalance");

        //    migrationBuilder.DropTable(
        //        name: "AuditLog");

        //    migrationBuilder.DropTable(
        //        name: "AuditTrail");

        //    migrationBuilder.DropTable(
        //        name: "Badges");

        //    migrationBuilder.DropTable(
        //        name: "BankAccounts");

        //    migrationBuilder.DropTable(
        //        name: "ChangeLog");

        //    migrationBuilder.DropTable(
        //        name: "Comments");

        //    migrationBuilder.DropTable(
        //        name: "CommentsAuditLog");

        //    migrationBuilder.DropTable(
        //        name: "DDLAuditLog");

        //    migrationBuilder.DropTable(
        //        name: "DeletedPosts");

        //    migrationBuilder.DropTable(
        //        name: "PostLinks");

        //    migrationBuilder.DropTable(
        //        name: "TransactionLog");

        //    migrationBuilder.DropTable(
        //        name: "TransferHistory");

        //    migrationBuilder.DropTable(
        //        name: "Votes");

        //    migrationBuilder.DropTable(
        //        name: "LinkTypes");

        //    migrationBuilder.DropTable(
        //        name: "Posts");

        //    migrationBuilder.DropTable(
        //        name: "Users");

        //    migrationBuilder.DropTable(
        //        name: "VoteTypes");

        //    migrationBuilder.DropTable(
        //        name: "PostTypes");
        //}
    }
}
