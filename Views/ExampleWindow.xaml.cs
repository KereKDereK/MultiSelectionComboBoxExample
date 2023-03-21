using ReactiveUI;
using SubjectScheduler.Models;
using MultiSelectionComboBoxExample.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;

namespace MultiSelectionComboBoxExample.Views
{
    public partial class ExampleWindow
    {
        public ExampleWindow()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                if (ViewModel is not ExampleViewModel viewModel)
                    return;
                viewModel.CloseRequestInteraction.RegisterHandler((InteractionContext<Unit, Unit> ctx) =>
                {
                    Close();
                    ctx.SetOutput(Unit.Default);
                });
            });
        }

        private IObservable<Unit> ContinueObservable(InteractionContext<Unit, Unit> ctx)
        {
            return Observable.Start(() =>
            {

                ctx.SetOutput(Unit.Default);
            }, RxApp.MainThreadScheduler);
        }
    }
}
