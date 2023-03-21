using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using SubjectScheduler.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MultiSelectionComboBoxExample.ViewModels
{
    public class ExampleEntity
    {
        public ObservableCollection<string> Spec { get; set; } = new ObservableCollection<string>();
        public List<string> Specs { get; }
        public List<string> Teachers { get; }

        public ExampleEntity()
        {
            Specs = new List<string>() { "1", "2", "3", "4" };
            Teachers = new List<string>() { "Иванов", "Петров", "Пупкин" };
        }
    }
    public class ExampleViewModel : ReactiveObject
    {
        public ObservableCollection<ExampleEntity> Entities { get; set; }
        public ReactiveCommand<Unit, Unit> AddEntity { get; }
        public ReactiveCommand<Unit, Unit> ContinueCommand { get; set; }
        public Interaction<Unit, Unit> CloseRequestInteraction { get; } = new();
        public ExampleViewModel()
        {
            Entities = new ObservableCollection<ExampleEntity>();
            AddEntity = ReactiveCommand.CreateFromTask(AddEntityImpl);
            ContinueCommand = ReactiveCommand.CreateFromTask(ContinueImpl);
        }
        private async Task<Unit> ContinueImpl()
        {
            await CloseRequestInteraction.Handle(Unit.Default);
            return Unit.Default;
        }
        private async Task<Unit> AddEntityImpl()
        {
            Console.WriteLine("[INFO] AddEntityImpl run");
            Entities.Add(new ExampleEntity());
            return Unit.Default;
        }
    }
}
