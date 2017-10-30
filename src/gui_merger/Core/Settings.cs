namespace gui_merger.Core
{
    //--------------------------------------------------
    public class Settings : PropertyChangedBase
    {
        private string _monoPath;
        private string _refPath;
        private string _commitFormat = @"
#replacing {CLASS_NAME}
export S1={A_FILE}
export S2={B_FILE}
export SF={A_PATH}
git checkout -b refsource_{CLASS_NAME}
sed -i ""s#$S1#$S2#g"" $SF
rm $S1
make
git add $S1
git add $SF
git commit -m '[{LIB}] {CLASS_NAME} from reference source'
git push origin refsource_{CLASS_NAME}
git checkout master";

        public string APath {
            get => _monoPath;
            set => SetPropertyValue(ref _monoPath, value);
        }
        public string BPath {
            get => _refPath;
            set => SetPropertyValue(ref _refPath, value);
        }
        /// <summary>
        /// Variables:
        /// {CLASS_NAME} -- replaced class name
        /// {A_FILE} -- relative path to A file
        /// {B_FILE} -- relative path to B file
        /// {LIB} -- parent directory to APath
        /// </summary>
        public string CommitFormat {
            get => _commitFormat;
            set => SetPropertyValue(ref _commitFormat, value);
        }
        public override string ToString() => $"{{\"{nameof(APath)}\":\"{APath}\",\"{nameof(BPath)}\":\"{BPath}\",\"{nameof(CommitFormat)}\":\"{CommitFormat}\"}}";
    }
}
