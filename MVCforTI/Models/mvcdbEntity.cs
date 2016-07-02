namespace MVCforTI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class mvcdbEntity : DbContext
    {
        public mvcdbEntity()
            : base("name=mvcdbEntity")
        {
        }

        public virtual DbSet<qn> qns { get; set; }
        public virtual DbSet<stuAttempt> stuAttempts { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<qn>()
                .Property(e => e.groupName)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.questionType)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.question)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.option1)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.option2)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.option3)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.option4)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.option5)
                .IsUnicode(false);

            modelBuilder.Entity<qn>()
                .Property(e => e.answer)
                .IsUnicode(false);

            modelBuilder.Entity<stuAttempt>()
                .Property(e => e.qns)
                .IsUnicode(false);

            modelBuilder.Entity<stuAttempt>()
                .Property(e => e.ans)
                .IsUnicode(false);

            modelBuilder.Entity<stuAttempt>()
                .Property(e => e.correctAns)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.midName)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.userId)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.pswd)
                .IsUnicode(false);
        }
    }
}
