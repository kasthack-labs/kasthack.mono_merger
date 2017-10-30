using System.ComponentModel;

namespace gui_merger.Core
{
    public class SettingsVM : PropertyChangedBase
    {
        private readonly Settings _model;
        public SettingsVM(Settings model)
        {
            _model = model;
            _model.PropertyChanged += OnModelPropertyChanged;
            _model.PropertyChanging += OnModelPropertyChanging;
        }

        private void OnModelPropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.APath):
                    OnPropertyChanging(nameof(APath));
                    break;
                case nameof(_model.BPath):
                    OnPropertyChanging(nameof(BPath));
                    break;
                case nameof(_model.CommitFormat):
                    OnPropertyChanging(nameof(_model.CommitFormat));
                    break;
            }
        }
        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.APath):
                    OnPropertyChanged(nameof(APath));
                    break;
                case nameof(_model.BPath):
                    OnPropertyChanged(nameof(BPath));
                    break;
                case nameof(_model.CommitFormat):
                    OnPropertyChanged(nameof(_model.CommitFormat));
                    break;
            }
        }

        public string APath {
            get => _model.APath;
            set => _model.APath = value;
        }
        public string BPath {
            get => _model.BPath;
            set => _model.BPath = value;
        }
        public string CommitFormat {
            get => _model.CommitFormat;
            set => _model.CommitFormat = value;
        }
    }
}
