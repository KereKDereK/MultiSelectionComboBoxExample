using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectScheduler.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ObservableCollection<Teacher> Teachers { get; set; } = new();
    }
}
