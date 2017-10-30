namespace gui_merger.Core
{
    public class MergePair : PropertyChangedBase
    {
        private MergeFile _a;
        private MergeFile _b;
        private string _className;
        private MergeStatus _state;

        public MergeFile A {
            get => _a;
            set => SetPropertyValue(ref _a, value);
        }
        public MergeFile B {
            get => _b;
            set => SetPropertyValue(ref _b, value);
        }
        public string ClassName {
            get => _className;
            set => SetPropertyValue(ref _className, value);
        }
        public MergeStatus Status {
            get => _state;
            set => SetPropertyValue(ref _state, value);
        }
    }
}
