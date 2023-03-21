using System.Collections.ObjectModel;

namespace SubjectScheduler.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Patronymic { get; set; } = "";
        public string FullName
        {
            get { return LastName + FirstName + Patronymic; }
        }
        public ObservableCollection<Subject> Subjects { get; set; } = new();
    }
}