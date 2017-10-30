using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;

namespace gui_merger.Core
{
    //-------------------------------------------------------------------------------------------------------------
    public class MergeFileVM : PropertyChangedBase
    {
        private readonly MergeFile _model;
        private Lazy<string> _textLazy;
        private string _rootPath;

        public string RootPath {
            get => _rootPath;
            set {
                if (SetPropertyValue(ref _rootPath, value)) OnPathChanged();
            }
        }
        public string AbsolutePath => !string.IsNullOrWhiteSpace(RootPath) ? Path.Combine(RootPath, RelativePath) : RelativePath;

        public string RelativePath => _model.Path;
        public int Lines => _model.Lines;

        public string Text {
            get {
                var ret = _textLazy.Value;
                return ret;
            }
            set { }
        }
        public MergeFileVM(MergeFile model)
        {
            Contract.Assert(model != null);
            _model = model;
            _model.PropertyChanged += OnModelPropertyChanged;
            _model.PropertyChanging += OnModelPropertyChanging;
            LoadText();
        }

        private void OnModelPropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.Lines):
                    OnPropertyChanging(nameof(Lines));
                    break;
                case nameof(_model.Path):
                    OnPropertyChanging(nameof(RelativePath));
                    OnPropertyChanging(nameof(AbsolutePath));
                    break;
            }
        }
        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.Lines):
                    OnPropertyChanged(nameof(Lines));
                    break;
                case nameof(_model.Path):
                    OnPropertyChanged(nameof(RelativePath));
                    OnPathChanged();
                    break;
            }
        }
        private void OnPathChanged()
        {
            OnPropertyChanged(nameof(AbsolutePath));
            LoadText();
        }
        private void LoadText()
        {
            OnPropertyChanging(nameof(Text));
            _textLazy = new Lazy<string>(() =>
                File.Exists(AbsolutePath)
                    ? File.ReadAllText(AbsolutePath)
                    : "<file not found>"
            );
            OnPropertyChanged(nameof(Text));
        }
        public void Reload() {
            OnPropertyChanging(nameof(Text));
            var v = File.Exists(AbsolutePath)
                    ? File.ReadAllText(AbsolutePath)
                    : "<file not found>";
            _textLazy = new Lazy<string>(() => v);
            OnPropertyChanged(nameof(Text));
        }
        public void ShowInExplorer() => Process.Start("explorer", $"/select,\"{AbsolutePath}\"");
    }
}
