using Microsoft.EntityFrameworkCore;
using Vacancies.DataAccess.Entities;

namespace Vacancies.DataAccess;

public class VacanciesDbContext : DbContext
{
    public DbSet<ApplicantEntity> Applicants { get; set; }
    public DbSet<EmployerEntity> Employers { get; set; }
    public DbSet<VacancyEntity> Vacancies { get; set; }
    public DbSet<ResponseEntity> Responses { get; set; }
    public DbSet<ResumeEntity> Resumes { get; set; }

    public VacanciesDbContext(DbContextOptions<VacanciesDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicantEntity>().HasKey( applicant => applicant.Id);
        
        modelBuilder.Entity<ResumeEntity>().HasKey(resume => resume.Id);
        modelBuilder.Entity<ResumeEntity>().HasOne(resume => resume.ApplicantEntity)
            .WithMany(applicant => applicant.Resumes)
            .HasForeignKey(resume => resume.ApplicantId);
        
        modelBuilder.Entity<ResponseEntity>().HasKey(responses => responses.Id);
        modelBuilder.Entity<ResponseEntity>().HasOne(responses => responses.ResumeEntity)
            .WithMany(resume => resume.Responses)
            .HasForeignKey(responses => responses.ResumeId);
        
        modelBuilder.Entity<VacancyEntity>().HasKey(vacancy => vacancy.Id);
        modelBuilder.Entity<VacancyEntity>().HasOne(vacancy => vacancy.ResponseEntity)
            .WithMany(responses => responses.Vacancies)
            .HasForeignKey(vacancy => vacancy.ResponseId);

        modelBuilder.Entity<EmployerEntity>().HasKey(employer => employer.Id);
        
        modelBuilder.Entity<VacancyEntity>().HasOne(vacancy => vacancy.EmployerEntity)
            .WithMany(employer => employer.Vacancies)
            .HasForeignKey(vacancy => vacancy.EmployerId);
    }
}