using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Person
    {
        [Key]
        public int ID {  get; set; }
        public string PersonName { get; set; }
    }

    public class PersonContext:DbContext
    {
        public DbSet<Person> Persons { get; set;}
        public PersonContext(DbContextOptions opt):base(opt)
        {

        }
        
    }




}
