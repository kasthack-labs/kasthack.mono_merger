using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace gui_merger.Core
{
    public class MergePairVM : PropertyChangedBase
    {
        private readonly MergePair _model;
        private MergeFileVM _a;
        private MergeFileVM _b;

        public MergePairVM(MergePair model)
        {
            Contract.Assert(_model != null);
            _model = model;
            _model.PropertyChanged += OnModelPropertyChanged;
            _model.PropertyChanging += OnModelPropertyChanging;
            SetupA();
            SetupB();
        }

        private void OnModelPropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.ClassName):
                    OnPropertyChanging(nameof(ClassName));
                    break;
                case nameof(_model.Status):
                    OnStatusChanging();
                    break;
                case nameof(_model.A):
                    OnPropertyChanging(nameof(A));
                    break;
                case nameof(_model.B):
                    OnPropertyChanging(nameof(B));
                    break;
            }
        }

        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_model.ClassName):
                    OnPropertyChanged(nameof(ClassName));
                    break;
                case nameof(_model.Status):
                    OnStatusChanged();
                    break;
                case nameof(_model.A):
                    SetupA();
                    break;
                case nameof(_model.B):
                    SetupB();
                    break;
            }
        }
        private void OnStatusChanged()
        {
            OnPropertyChanged(nameof(IsMergeDefault));
            OnPropertyChanged(nameof(IsMergeAccepted));
            OnPropertyChanged(nameof(IsMergeRejected));
            OnPropertyChanged(nameof(IsMergeReview));
        }
        private void OnStatusChanging()
        {
            OnPropertyChanging(nameof(IsMergeDefault));
            OnPropertyChanging(nameof(IsMergeAccepted));
            OnPropertyChanging(nameof(IsMergeRejected));
            OnPropertyChanging(nameof(IsMergeReview));
        }
        private void SetStatus(MergeStatus status, bool matches)
        {
            if (matches)
                _model.Status = status;
        }
        private void SetupA() => A = new MergeFileVM(_model.A);
        private void SetupB() => B = new MergeFileVM(_model.B);

        public MergeFileVM A {
            get => _a;
            private set => SetPropertyValue(ref _a, value);
        }
        public MergeFileVM B {
            get => _b;
            private set => SetPropertyValue(ref _b, value);
        }
        public string ClassName => _model.ClassName;
        public bool IsMergeDefault {
            get => _model.Status == MergeStatus.Default;
            set => SetStatus(MergeStatus.Default, value);
        }
        public bool IsMergeAccepted {
            get => _model.Status == MergeStatus.Accepted;
            set => SetStatus(MergeStatus.Accepted, value);
        }
        public bool IsMergeRejected {
            get => _model.Status == MergeStatus.Rejected;
            set => SetStatus(MergeStatus.Rejected, value);
        }
        public bool IsMergeReview {
            get => _model.Status == MergeStatus.Review;
            set => SetStatus(MergeStatus.Review, value);
        }
    }
}
