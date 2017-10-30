using System.Collections.Generic;

namespace gui_merger.Core
{
    public class MergeState : PropertyChangedBase
    {
        private Settings _settings;
        private IReadOnlyCollection<MergePair> _pairs;

        public Settings Settings {
            get => _settings;
            set => SetPropertyValue(ref _settings, value);
        }
        public IReadOnlyCollection<MergePair> Pairs {
            get => _pairs;
            set => SetPropertyValue(ref _pairs, value);
        }
    }
}
