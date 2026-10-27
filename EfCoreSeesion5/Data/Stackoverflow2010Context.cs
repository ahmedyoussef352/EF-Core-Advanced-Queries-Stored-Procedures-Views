using EfCoreSeesion5.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreSeesion5.Data;

public partial class Stackoverflow2010Context : DbContext
{
    public Stackoverflow2010Context()
    {
    }

    public Stackoverflow2010Context(DbContextOptions<Stackoverflow2010Context> options)
        : base(options)
    {
    }
    public class TopPostScore
    {
        public int PostId { get; set; }
        public string? PostTitle { get; set; }
        public int PostScore { get; set; }
        public override string ToString()
        {
            return $"ID: {PostId} | Score: {PostScore} | Title: {PostTitle}";
        }
    }
    public virtual DbSet<TopPostScore> TopPostScores { get; set; }
    public virtual DbSet<AccountBalance> AccountBalances { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AuditTrail> AuditTrails { get; set; }

    public virtual DbSet<Badge> Badges { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<ChangeLog> ChangeLogs { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<CommentsAuditLog> CommentsAuditLogs { get; set; }

    public virtual DbSet<DdlauditLog> DdlauditLogs { get; set; }

    public virtual DbSet<DeletedPost> DeletedPosts { get; set; }

    public virtual DbSet<LinkType> LinkTypes { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostLink> PostLinks { get; set; }

    public virtual DbSet<PostType> PostTypes { get; set; }

    public virtual DbSet<TransactionLog> TransactionLogs { get; set; }

    public virtual DbSet<TransferHistory> TransferHistories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VPost> VPosts { get; set; }

    public virtual DbSet<Vote> Votes { get; set; }

    public virtual DbSet<VoteType> VoteTypes { get; set; }

    public virtual DbSet<VwUserPostMetric> VwUserPostMetrics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=StackOverflow2010;Trusted_Connection=True; TrustServerCertificate=True;")
        .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
        .EnableSensitiveDataLogging();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //// class UserResponse
        //modelBuilder.Entity<UserResponse>(t =>
        //{
        //    t.HasKey();
        //    t.ToView(null);
        //}
        //);
        // view
        modelBuilder.Entity<TopPostScore>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("vw_Top10PostsByScore2");
        });

        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AccountBalance>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__AccountB__349DA5A6440E7185");

            entity.ToTable("AccountBalance");

            entity.Property(e => e.AccountId).ValueGeneratedNever();
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__AuditLog__A17F2398BCEBEDAD");

            entity.ToTable("AuditLog");

            entity.Property(e => e.ChangeDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Details).HasMaxLength(500);
            entity.Property(e => e.OperationType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AuditTrail>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__AuditTra__A17F239884C2205D");

            entity.ToTable("AuditTrail");

            entity.Property(e => e.AuditDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<Badge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Badges__Id");

            entity.ToTable(tb => tb.HasTrigger("TR_BadgeOperation"));

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(40);

            entity.HasOne(d => d.User).WithMany(p => p.Badges)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Badges_Users");
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__BankAcco__349DA5A63AA37696");

            entity.Property(e => e.AccountId).ValueGeneratedNever();
            entity.Property(e => e.AccountHolder)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ChangeLog>(entity =>
        {
            entity.HasKey(e => e.ChangeLogId).HasName("PK__ChangeLo__6AD2E8C7B1E9540D");

            entity.ToTable("ChangeLog");

            entity.Property(e => e.ActionType).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Comments__Id");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TR_Audit_Comments");
                    tb.HasTrigger("TR_INSTEADOFDELETE");
                });

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Text).HasMaxLength(700);

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_Posts");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Comments_Users");
        });

        modelBuilder.Entity<CommentsAuditLog>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__Comments__A17F239893D936DA");

            entity.ToTable("CommentsAuditLog");

            entity.Property(e => e.ChangeDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ChangedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OperationType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DdlauditLog>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__DDLAudit__7944C81082483A4D");

            entity.ToTable("DDLAuditLog");

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EventDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EventType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LoginName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tsqlcommand).HasColumnName("TSQLCommand");
        });

        modelBuilder.Entity<DeletedPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeletedP__3214EC077E0BD370");

            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<LinkType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LinkTypes__Id");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Posts__Id");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TR_AfterDeletedPosts");
                    tb.HasTrigger("TR_InsteadOfUpdate");
                    tb.HasTrigger("TR_isteadOfDelete");
                    tb.HasTrigger("Tr_InsertAfterPosts");
                });

            entity.HasIndex(e => new { e.OwnerUserId, e.Score, e.CreationDate }, "IX_Post")
                .IsDescending(false, true, false)
                .HasFilter("([OwnerUserId]=(22656) AND [Score]>(100) AND [Title] IS NOT NULL)");

            entity.Property(e => e.ClosedDate).HasColumnType("datetime");
            entity.Property(e => e.CommunityOwnedDate).HasColumnType("datetime");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LastEditDate).HasColumnType("datetime");
            entity.Property(e => e.LastEditorDisplayName).HasMaxLength(40);
            entity.Property(e => e.Tags).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(250);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Posts_Posts");

            entity.HasOne(d => d.PostType).WithMany(p => p.Posts)
                .HasForeignKey(d => d.PostTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Posts_PostTypes");
        });

        modelBuilder.Entity<PostLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PostLinks__Id");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");

            entity.HasOne(d => d.LinkType).WithMany(p => p.PostLinks)
                .HasForeignKey(d => d.LinkTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostLinks_LinkTypes");

            entity.HasOne(d => d.Post).WithMany(p => p.PostLinks)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostLinks_Posts");
        });

        modelBuilder.Entity<PostType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PostTypes__Id");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TransactionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Transact__5E54864885F7C398");

            entity.ToTable("TransactionLog");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransferHistory>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PK__Transfer__95490091CDB2B34A");

            entity.ToTable("TransferHistory");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransferDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users_Id");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TR_InsteadOfInsert");
                    tb.HasTrigger("TR_UpdateUserRepu");
                });

            entity.HasIndex(e => e.DisplayName, "IX_Users_DisplayName")
                .IsUnique()
                .IsDescending();

            entity.HasIndex(e => e.Reputation, "IX_Users_Reputation").IsDescending();

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(40);
            entity.Property(e => e.EmailHash).HasMaxLength(40);
            entity.Property(e => e.LastAccessDate).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.WebsiteUrl).HasMaxLength(200);
        });

        modelBuilder.Entity<VPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Post");
        });

        modelBuilder.Entity<Vote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Votes__Id");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");

            entity.HasOne(d => d.Post).WithMany(p => p.Votes)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Votes_Posts");

            entity.HasOne(d => d.User).WithMany(p => p.Votes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Votes_Users");

            entity.HasOne(d => d.VoteType).WithMany(p => p.Votes)
                .HasForeignKey(d => d.VoteTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Votes_VoteTypes");
        });

        modelBuilder.Entity<VoteType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VoteType__Id");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwUserPostMetric>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_UserPostMetrics");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
