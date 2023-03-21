using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectScheduler.Models
{
    public class ClassroomsSet
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public ObservableCollection<Classroom> Classrooms { get; set; } = new();
    }
}