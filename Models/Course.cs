using System;
using System.ComponentModel.DataAnnotations;

namespace SubjectScheduler.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.Today;
        public ClassroomsSet ClassroomsSet { get; set; }
        public SubjectsSet SubjectsSet { get; set; }
        public TeachersSet TeachersSet { get; set; }
    }
}