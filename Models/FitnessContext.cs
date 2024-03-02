using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FitNet.Models;

public class FitnessContext : DbContext
{
    public FitnessContext(DbContextOptions<FitnessContext> option) : base(option) { }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<WorkoutEntry> WorkoutEntries { get; set; }
    public DbSet<Scheme> Schemes { get; set; }
    public DbSet<Muscle> Muscles { get; set; }
}
