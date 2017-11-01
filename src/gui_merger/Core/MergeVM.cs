using System;
using System.ComponentModel;

namespace gui_merger.Core
{
    public class MergeVM : PropertyChangedBase
    {
        private Merge _model;
        private MergeStateVM _state;

        public MergeStateVM State {
            get => _state;
            private set => SetPropertyValue(ref _state, value);
        }
        public string Output => _model.Output;
        public MergeVM(Merge model)
        {
            _model = model;
            SetupState();
            _model.PropertyChanged += OnModelPropertyChanged;
            _model.PropertyChanging += OnModelPropertyChanging;
        }

        private void OnModelPropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.State):
                    OnPropertyChanging(nameof(_model.State));
                    break;
                case nameof(_model.Output):
                    OnPropertyChanging(nameof(_model.Output));
                    break;
            }
        }

        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.State):
                    SetupState();
                    break;
                case nameof(_model.Output):
                    OnPropertyChanged(nameof(_model.Output));
                    break;
            }
        }

        private void SetupState() => State = new MergeStateVM(_model.State);
        public void Merge() => _model.Merge();
    }
}
