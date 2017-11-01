using ScintillaNET;

namespace gui_merger.Controls
{
    /*workaround for https://github.com/jacobslusser/ScintillaNET/issues/360 */
    public class RWScintilla : Scintilla
    {
        public override string Text {
            get => base.Text;
            set {
                var ro = ReadOnly;
                if (ro)
                    ReadOnly = false;
                base.Text = value;
                if (ro)
                    ReadOnly = true;
            }
        }
    }
}
