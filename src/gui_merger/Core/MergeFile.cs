namespace gui_merger.Core
{
    public class MergeFile : PropertyChangedBase
    {
        private string _path;
        private int _lines;

        public string Path {
            get => _path;
            set => SetPropertyValue(ref _path, value);
        }
        public int Lines {
            get => _lines;
            set => SetPropertyValue(ref _lines, value);
        }
    }
}
