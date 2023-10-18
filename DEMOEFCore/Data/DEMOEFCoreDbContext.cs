using DEMOEFCore.Model;
using Microsoft.EntityFrameworkCore;

namespace DEMOEFCore.Data
{
    public class DEMOEFCoreDbContext : DbContext
    {
        public DEMOEFCoreDbContext(DbContextOptions<DEMOEFCoreDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<PersonDetail> PersonDetails { get; set; }

        // Seed the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 1, DepartmentName = "Department 1" },
                new Department() { DepartmentId = 2, DepartmentName = "Department 2" },
                new Department() { DepartmentId = 3, DepartmentName = "Department 3" },
                new Department() { DepartmentId = 4, DepartmentName = "Department 4" },
                new Department() { DepartmentId = 5, DepartmentName = "Department 5" });

            modelBuilder.Entity<Position>().HasData(
                new Position() { PositionId = 1, PositionName = "Position 1", DepartmentId = 1 },
                new Position() { PositionId = 2, PositionName = "Position 2", DepartmentId = 2 },
                new Position() { PositionId = 3, PositionName = "Position 3", DepartmentId = 2 },
                new Position() { PositionId = 4, PositionName = "Position 4", DepartmentId = 3 },
                new Position() { PositionId = 5, PositionName = "Position 5", DepartmentId = 4 });

            modelBuilder.Entity<Salary>().HasData(
                new Salary() { SalaryId = 1, Amount = 600 },
                new Salary() { SalaryId = 2, Amount = 400 },
                new Salary() { SalaryId = 3, Amount = 500 },
                new Salary() { SalaryId = 4, Amount = 200 },
                new Salary() { SalaryId = 5, Amount = 100 });

            modelBuilder.Entity<Person>().HasData(
               new Person() { PersonId = 1, Name = "John", Surname = "Doe", Age = 45, Email = "j@j.com", Password = "1234", Address = "1313 Doe Ave", PositionId = 1, SalaryId = 2 },
               new Person() { PersonId = 2, Name = "Jane", Surname = "Doe", Age = 42, Email = "j@j.com", Password = "1234", Address = "1313 Doe Ave", PositionId = 1, SalaryId = 2 },
               new Person() { PersonId = 3, Name = "Jim", Surname = "Doe", Age = 25, Email = "j@j.com", Password = "1234", Address = "1313 Doe Ave", PositionId = 1, SalaryId = 2 },
               new Person() { PersonId = 4, Name = "Jean", Surname = "Doe", Age = 15, Email = "j@j.com", Password = "1234", Address = "1313 Doe Ave", PositionId = 1, SalaryId = 2 },
               new Person() { PersonId = 5, Name = "Jackie", Surname = "Doe", Age = 10, Email = "j@j.com", Password = "1234", Address = "1313 Doe Ave", PositionId = 1, SalaryId = 2 });

            modelBuilder.Entity<PersonDetail>().HasData(
               new PersonDetail() { PersonDetailId = 1, PersonCity = "Chandler", PersonId = 2 },
               new PersonDetail() { PersonDetailId = 2, PersonCity = "Chandler", PersonId = 1 },
               new PersonDetail() { PersonDetailId = 3, PersonCity = "Chandler", PersonId = 3 },
               new PersonDetail() { PersonDetailId = 4, PersonCity = "Chandler", PersonId = 4 },
               new PersonDetail() { PersonDetailId = 5, PersonCity = "Chandler", PersonId = 5 });
        }
    }

}
