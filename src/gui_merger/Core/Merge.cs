using System;

namespace gui_merger.Core
{
    public class Merge : PropertyChangedBase
    {
        private MergeState _state;
        private string _output;
        public Merge() => State = new MergeState()
        {
            Settings = new Settings
            {
                
            },
            Pairs = Array.Empty<MergePair>()
        };

        public MergeState State {
            get => _state;
            set => SetPropertyValue(ref _state, value);
        }
        public string Output {
            get => _output;
            set => SetPropertyValue(ref _output, value);
        }

        internal void Merge() => throw new NotImplementedException();
    }
}
