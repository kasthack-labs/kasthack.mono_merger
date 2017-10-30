#define DBG_Q
using gui_merger.Core;
using Microsoft.WindowsAPICodePack.Dialogs;
using ScintillaNET;
using System;
using System.Windows.Forms;

namespace gui_merger
{
    public partial class frm_main : Form
    {
        private readonly Merge model;
        private readonly MergeVM vm;

        public frm_main()
        {
            InitializeComponent();
            foreach (var v in new[] {
                txt_commit_format,
                txt_file_a,
                txt_file_b,
                txt_ouput,
                txt_sources_file
            })
                SetupCodeEditor(v);

            model = new Merge();
            vm = new MergeVM(model);

            //settings panel
            txt_a_path.DataBindings.Add(nameof(TextBox.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.Settings)}.{nameof(vm.State.Settings.APath)}", false, DataSourceUpdateMode.OnPropertyChanged);
            txt_b_path.DataBindings.Add(nameof(TextBox.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.Settings)}.{nameof(vm.State.Settings.BPath)}", false, DataSourceUpdateMode.OnPropertyChanged);
#if DBG_Q
            lbl_commit_format.Text = "Actually, source file";
            txt_commit_format.DataBindings.Add(nameof(Scintilla.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.SourcesFile)}.{nameof(vm.State.SourcesFile.Text)}", false, DataSourceUpdateMode.OnPropertyChanged);
#else
            txt_commit_format.DataBindings.Add(nameof(Scintilla.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.Settings)}.{nameof(vm.State.Settings.CommitFormat)}", false, DataSourceUpdateMode.OnPropertyChanged);

            //merge panel

            //top:
            lbl_sources_file_path.DataBindings.Add(nameof(Label.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.SourcesFile)}.{nameof(vm.State.SourcesFile.AbsolutePath)}", false, DataSourceUpdateMode.OnPropertyChanged);
            txt_sources_file.DataBindings.Add(nameof(Scintilla.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.SourcesFile)}.{nameof(vm.State.SourcesFile.Text)}", false, DataSourceUpdateMode.Never);

            //bottom

            //left
            lbl_file_a_path.DataBindings.Add(nameof(Label.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.CurrentPair)}.{nameof(vm.State.CurrentPair.A)}.{nameof(vm.State.CurrentPair.A.AbsolutePath)}", false, DataSourceUpdateMode.Never);
            txt_file_a.DataBindings.Add(nameof(Scintilla.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.CurrentPair)}.{nameof(vm.State.CurrentPair.A)}.{nameof(vm.State.CurrentPair.A.Text)}", false, DataSourceUpdateMode.Never);

            //right
            lbl_file_b_path.DataBindings.Add(nameof(Label.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.CurrentPair)}.{nameof(vm.State.CurrentPair.B)}.{nameof(vm.State.CurrentPair.B.AbsolutePath)}", false, DataSourceUpdateMode.Never);
            txt_file_b.DataBindings.Add(nameof(Scintilla.Text), vm, $"{nameof(vm.State)}.{nameof(vm.State.CurrentPair)}.{nameof(vm.State.CurrentPair.B)}.{nameof(vm.State.CurrentPair.B.Text)}", false, DataSourceUpdateMode.Never);
#endif
        }

        void SetupCodeEditor(Scintilla scintilla)
        {
            var margin = scintilla.Margins[0];
            margin.Type = MarginType.Number;
            margin.Width = 16;
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {

        }

        private void btn_refsource_directory_Click(object sender, EventArgs e)
        {
            using (var fd = new CommonOpenFileDialog()
            {
                AddToMostRecentlyUsedList = true,
                AllowNonFileSystemItems = false,
                IsFolderPicker = true,
                EnsurePathExists = true,
                RestoreDirectory = true,
                Multiselect = false,
                Title = "B source path"
            }) {
                if (fd.ShowDialog() == CommonFileDialogResult.Ok) {
                    txt_b_path.Text = fd.FileName;
                }
            }
        }

        private void btn_browse_sources_file_Click(object sender, EventArgs e)
        {
            using (var fd = new CommonOpenFileDialog()
            {
                AddToMostRecentlyUsedList = true,
                AllowNonFileSystemItems = false,
                IsFolderPicker = false,
                EnsurePathExists = true,
                RestoreDirectory = true,
                Multiselect = false,
                Title = "A sources file"
            })
            {
                if (fd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txt_a_path.Text = fd.FileName;
                }
            }
        }

        private void btn_browse_to_file_a_Click(object sender, EventArgs e) => vm.State.CurrentPair?.A?.ShowInExplorer();
        private void btn_browse_to_file_b_Click(object sender, EventArgs e) => vm.State.CurrentPair?.B?.ShowInExplorer();
        private void btn_browse_to_sources_file_Click(object sender, EventArgs e) => vm.State?.SourcesFile?.ShowInExplorer();
        private void btn_sources_file_reload_Click(object sender, EventArgs e) => vm.State?.SourcesFile?.Reload();
        private void btn_file_a_reload_Click(object sender, EventArgs e) => vm.State?.CurrentPair?.A?.Reload();
        private void btn_file_b_reload_Click(object sender, EventArgs e) => vm.State?.CurrentPair?.B?.Reload();
    }
}
