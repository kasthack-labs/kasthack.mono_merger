using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace gui_merger.Core
{
    public class MergeStateVM : PropertyChangedBase
    {
        private readonly MergeState _model;
        private MergeFileVM _sourcesFile;
        private SettingsVM _settings;
        private ObservableCollection<MergePairVM> _pairs;
        private MergePairVM _currentPair;
        public MergeFileVM SourcesFile {
            get => _sourcesFile;
            set => SetPropertyValue(ref _sourcesFile, value);
        }
        public MergePairVM CurrentPair {
            get => _currentPair;
            private set => SetPropertyValue(ref _currentPair, value);
        }
        public ObservableCollection<MergePairVM> Pairs {
            get => _pairs;
            private set => SetPropertyValue(ref _pairs, value);
        }
        public SettingsVM Settings {
            get => _settings;
            private set => SetPropertyValue(ref _settings, value);
        }

        public MergeStateVM(MergeState model)
        {
            _model = model;
            Pairs = new ObservableCollection<MergePairVM>();
            SetupSettings();
            SetupPairs();
            SetupPair(0);
            _model.PropertyChanged += OnModelPropertyChanged;
            _model.PropertyChanging += OnModelPropertyChanging;
        }
        private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Settings.APath):
                    SetupSourceFile();
                    break;
            }
        }

        private void SetupSourceFile() => SourcesFile = new MergeFileVM(new MergeFile { Path = Settings.APath });

        private void SetupSettings()
        {
            if (Settings != null)
                Settings.PropertyChanged -= OnSettingsPropertyChanged;
            Settings = new SettingsVM(_model.Settings);
            SetupSourceFile();
            Settings.PropertyChanged += OnSettingsPropertyChanged;
        }
        private void SetupPairs() {
            Pairs.Clear();
            foreach (var v in _model.Pairs)
            {
                Pairs.Add(new MergePairVM(v));
            }
        }
        private void SetupPair(int index) => CurrentPair = index >= 0 && index < Pairs.Count ? Pairs[index] : null;//todo
        private void OnModelPropertyChanging(object sender, PropertyChangingEventArgs e) {
            switch (e.PropertyName)
            {
                case nameof(_model.Pairs):
                    SetupPairs();
                    SetupPair(0);
                    break;
                case nameof(_model.Settings):
                    SetupSettings();
                    break;
            }
        }
        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e) {
            switch (e.PropertyName)
            {
                case nameof(_model.Pairs):
                    OnPropertyChanging(nameof(CurrentPair));
                    break;
                case nameof(_model.Settings):
                    SetupSettings();
                    break;
            }
        }
    }
}
